﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class DataManager
{
    /// <summary>
    /// 是否生效
    /// </summary>
    private static bool isEnable = false;

    /// <summary>
    /// 是否选中在了有效区域内
    /// </summary>
    public static bool isWorkRange = false;

    private static FieldType currentFieldType;
    private static DataFieldAssetType currentAssetType;
    private static string currentSecType ="";

    /// <summary>
    /// 外部数据缓存
    /// </summary>
    static Dictionary<string, DataTable> dataCache = new Dictionary<string, DataTable>();

    /// <summary>
    /// 表名缓存
    /// </summary>
    static List<string> tableNameCache = new List<string>();

    /// <summary>
    /// 枚举缓存
    /// </summary>
    static Dictionary<string, List<string>> enumCache = new Dictionary<string, List<string>>();

    /// <summary>
    /// 枚举名称缓存
    /// </summary>
    static List<string> enumNameCache = new List<string>();

    public static FieldType CurrentFieldType
    {
        get => currentFieldType;
        set
        {
            //重设其他属性的值
            if (value != currentFieldType)
            {
                currentAssetType = DataFieldAssetType.Data;

                if((value == FieldType.Enum 
                    || value == FieldType.EnumArray)
                    && enumNameCache.Count > 0)
                {
                    currentSecType = enumNameCache[0];
                }
                else
                {
                    currentSecType = "";
                }
            }

            currentFieldType = value;
        }
    }

    public static DataFieldAssetType CurrentAssetType
    {
        get => currentAssetType;
        set
        {
            //重设二级类型的值
            if (currentAssetType != value)
            {
                if(value == DataFieldAssetType.TableKey && tableNameCache.Count>0)
                {
                    currentSecType = tableNameCache[0];
                }
                else
                {
                    currentSecType = "";
                }
            }

            currentAssetType = value;
        }
    }

    public static string CurrentSecType { get => currentSecType; set => currentSecType = value; }
    public static List<string> TableName { get => tableNameCache;  }
    public static List<string> EnumName { get => enumNameCache;  }
    public static bool IsEnable {
        get => isEnable;

        set
        {
            isEnable = value;

            if(!isEnable)
            {
                isWorkRange = false;

                //全部默认值
                CurrentFieldType = FieldType.String;
                CurrentAssetType = DataFieldAssetType.Data;
                CurrentSecType = "";
            }
        }
    }

    public static void Init(Worksheet config)
    {
        isEnable = true;

        //生成缓存
        GenerateDataCache();

        //读取枚举设置
        ReadEnumConfig(config);
    }

    static void GenerateDataCache()
    {
        List<string> errorFile = new List<string>();
        dataCache = new Dictionary<string, DataTable>();
        tableNameCache = new List<string>();

        if (!Directory.Exists(PathDefine.GetDataPath()))
        {
            return;
        }

        List<string> list = FileTool.GetAllFileNamesByPath(PathDefine.GetDataPath(), new string[] { "txt" },false);

        for (int j = 0; j < list.Count; j++)
        {
            string key = FileTool.RemoveExpandName(FileTool.GetFileNameByPath(list[j]));
            try
            {
                string content = FileTool.ReadStringByFile(list[j]);
                DataTable data = DataTable.Analysis(content);

                dataCache.Add(key, data);
            }
            catch (Exception)
            {
                errorFile.Add(key);
            }
        }

        //缓存表名
        foreach (string key in dataCache.Keys)
        {
            tableNameCache.Add(key);
        }

        //TODO 构造枚举名

        if (errorFile.Count > 0)
        {
            string info = "构造以下配置表时出现错误，请检查相应文件";
            for (int i = 0; i < errorFile.Count; i++)
            {
                info += "\n->" + errorFile[i];
            }

            MessageBox.Show(info);
        }
    }

    static void ReadEnumConfig(Worksheet config)
    {
        int col = 5;
        int row = 2;

        enumNameCache = new List<string>();
        enumCache = new Dictionary<string, List<string>>();

        //横向读取枚举名称
        while(!string.IsNullOrEmpty(config.Cells[row,col].Text))
        {
            //纵向读取枚举内容
            string enumName = config.Cells[row, col].Text;
            
            enumNameCache.Add(enumName);

            row++;
            List<string> list = new List<string>();
            while (!string.IsNullOrEmpty(config.Cells[row, col].Text))
            {
                string enumValue = config.Cells[row, col].Text;
                list.Add(enumValue);

                row++;
            }

            if(!enumCache.ContainsKey(enumName))
            {
                enumCache.Add(enumName, list);
            }
            else
            {
                MessageBox.Show("重复的枚举名 " + enumName);
            }

            row = 2;
            col++;
        }
    }

    /// <summary>
    /// 将某个表的枚举数据添加到配置中去
    /// </summary>
    public static void WriteEnumConfig(DataConfig dataConfig, Worksheet configSheet)
    {
        //刷新一次枚举表
        ReadEnumConfig(configSheet);

        DataTable data = DataTable.Analysis(FileTool.ReadStringByFile(dataConfig.GetTextPath()));

        //找到枚举名称
        for (int i = 0; i < data.TableKeys.Count; i++)
        {
            string key = data.TableKeys[i];
            if (data.m_tableTypes.ContainsKey(key) 
                && (data.m_tableTypes[key] == FieldType.Enum || data.m_tableTypes[key] == FieldType.EnumArray))
            {
                string enumName = data.m_tableSecTypes[key];
                
                //再找到有没有相同的枚举
                FindEnumConfig(data, configSheet,key, enumName, data.m_tableTypes[key]);
            }
        }
    }

    static void FindEnumConfig(DataTable data, Worksheet configSheet,string key,string enumName,FieldType fieldType)
    {
        List<string> enumList = null;
        int col = 5;
        int row = 2;

        if(enumCache.ContainsKey(enumName))
        {
            enumList = enumCache[enumName];
            //找到对应的列index
            col = ExcelTool.FindCellByCol(configSheet, row, col, enumName);
        }
        else
        {
            enumList = new List<string>();
            enumCache.Add(enumName,enumList);
            //创建一个新的列表
            col = ExcelTool.GetEmptyCellByCol(configSheet, row, col);
            configSheet.Cells[row, col].Value = enumName;
        }

        //遍历所有的id,查找所有枚举的变量
        for (int i = 0; i < data.TableIDs.Count; i++)
        {
            if(fieldType == FieldType.Enum)
            {
                string value = data[data.TableIDs[i]].GetString(key);

                if (!enumList.Contains(value))
                {
                    enumList.Add(value);

                    //写在队尾
                    row = ExcelTool.GetEmptyCellByRow(configSheet, row, col);
                    configSheet.Cells[row, col].Value = value;
                }
            }
            else if(fieldType == FieldType.EnumArray)
            {
                string[] values = data[data.TableIDs[i]].GetStringArray(key);
                for (int j = 0; j < values.Length; j++)
                {
                    string value = values[j];
                    if (!enumList.Contains(value))
                    {
                        enumList.Add(value);

                        //写在队尾
                        row = ExcelTool.GetEmptyCellByRow(configSheet, row, col);
                        configSheet.Cells[row, col].Value = value;
                    }
                }
            }
            else
            {
                MessageBox.Show("FindEnumConfig 意外的类型 " + fieldType);
            }
        }
    }

    public static bool CheckDataFileNameExist( string fileName)
    {
        if (!isEnable)
            return true;

        return dataCache.ContainsKey(fileName);
    }

    public static bool CheckDataExist( string fileName, string key)
    {
        if (!isEnable)
            return true;

        return dataCache[fileName].ContainsKey(key);
    }


    public static List<string> GetTableKeyList(string tableName)
    {
        List<string> list = new List<string>();

        if(dataCache.ContainsKey(tableName))
        {
            return dataCache[tableName].TableIDs;
        }

        return list;
    }

    public static List<string> GetEnumList(string enumName)
    {
        List<string> list = new List<string>();

        if (enumCache.ContainsKey(enumName))
        {
            return enumCache[enumName];
        }

        return list;
    }

    public static List<string> GetTextureList()
    {
        List<string> list = new List<string>();

        //构造图片清单
        List<string> res = FileTool.GetAllFileNamesByPath(PathDefine.GetResourcesPath(), new string[] { "png", "jpg", "jpeg" });

        for (int i = 0; i < res.Count; i++)
        {
            list.Add(FileTool.RemoveExpandName(FileTool.GetFileNameByPath(res[i])));
        }

        return list;
    }

    public static List<string> GetPrefabList()
    {
        List<string> list = new List<string>();

        //构造预设清单
        List<string> res = FileTool.GetAllFileNamesByPath(PathDefine.GetResourcesPath(), new string[] { "prefab" });

        for (int i = 0; i < res.Count; i++)
        {
            list.Add(FileTool.RemoveExpandName(FileTool.GetFileNameByPath(res[i])));
        }

        return list;
    }

    public static FieldTypeStruct PaseToFieldStructType(string typeString)
    {
        FieldTypeStruct typeStruct = new FieldTypeStruct();

        if (typeString == null)
        {
            //全部默认值
            typeStruct.fieldType = FieldType.String;
            typeStruct.assetType = DataFieldAssetType.Data;
            typeStruct.secType = "";
        }
        else
        {
            isWorkRange = true;

            if (typeString == "")
            {
                //全部默认值
                typeStruct.fieldType = FieldType.String;
                typeStruct.assetType = DataFieldAssetType.Data;
                typeStruct.secType = "";
            }
            else
            {
                string[] tempType = typeString.Split(DataTable.c_DataFieldAssetTypeSplit);
                string[] content = tempType[0].Split(DataTable.c_EnumSplit);

                try
                {
                    string fieldType = content[0];
                    if (fieldType.Contains("["))
                    {
                        string[] tempSS = fieldType.Split('[');
                        fieldType = tempSS[0];
                        string splitStr = tempSS[1].Replace("]", "");
                        //data.m_ArraySplitFormat.Add(field, splitStr.ToCharArray());
                    }

                    typeStruct.fieldType = (FieldType)Enum.Parse(typeof(FieldType), fieldType);

                    if (content.Length > 1)
                    {
                        typeStruct.secType = content[1];
                    }
                    else
                    {
                        typeStruct.secType = "";
                    }
                }
                catch (Exception)
                {
                    typeStruct.fieldType = FieldType.String;
                    typeStruct.secType = "";
                }

                if (tempType.Length > 1)
                {
                    typeStruct.assetType = (DataFieldAssetType)Enum.Parse(typeof(DataFieldAssetType), tempType[1]);
                }
                else
                {
                    typeStruct.assetType = DataFieldAssetType.Data;
                }
            }
        }


        return typeStruct;
    }


    /// <summary>
    /// 解析
    /// </summary>
    /// <param name="typeString"></param>
    public static void PaseToCurrentType(string typeString)
    {
        FieldTypeStruct typeStruct = PaseToFieldStructType(typeString);

        CurrentFieldType = typeStruct.fieldType;
        CurrentAssetType = typeStruct.assetType;
        CurrentSecType = typeStruct.secType;

        if (typeString == null)
        {
            isWorkRange = false;
        }
        else
        {
            isWorkRange = true;
        }
    }

    public static string GetCurrentTypeString()
    {
        string typeString = CurrentFieldType.ToString();

        if(!string.IsNullOrEmpty(CurrentSecType))
        {
            typeString += "|" + CurrentSecType;
        }

        if(CurrentAssetType != DataFieldAssetType.Data)
        {
            typeString += "&" + CurrentAssetType;
        }

        return typeString;
    }
}

public struct FieldTypeStruct
{
    public FieldType fieldType ;
    public DataFieldAssetType assetType ;
    public string secType;
}

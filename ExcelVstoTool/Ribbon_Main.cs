﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelVstoTool
{
    public partial class Ribbon_Main
    {

        private void Ribbon_Main_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button_initData_Click(object sender, RibbonControlEventArgs e)
        {
            //判断 config 页是否存在
            Worksheet config; 

            if (!ExcelTool.ExistSheetName(Globals.ThisAddIn.Application, DataConfig.c_ConfigSheetName))
            {
                //创建一个Config 页面
                config = ExcelTool.CreateSheet(Globals.ThisAddIn.Application, DataConfig.c_ConfigSheetName);

                DataConfig.ConfigInit(config);
            }
            else
            {
                config = Globals.ThisAddIn.Application.Worksheets[DataConfig.c_ConfigSheetName];
                MessageBox.Show(DataConfig.c_ConfigSheetName + "页面已经存在");
            }
        }

        private void button_toTxt_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet config = ExcelTool.GetSheet(Globals.ThisAddIn.Application, DataConfig.c_ConfigSheetName);

            //没有初始化直接返回
            if (config == null)
            {
                return;
            }

            //获取真实路径

            //进行转换
            for (int i = 2; i < config.UsedRange.Rows.Count + 1; i++)
            {
                DataConfig dataConfig = new DataConfig(config, i);

                if (!string.IsNullOrEmpty(dataConfig.m_sheetName) && !string.IsNullOrEmpty(dataConfig.m_txtPath))
                {
                    Worksheet wst = ExcelTool.GetSheet(Globals.ThisAddIn.Application, dataConfig.m_sheetName, true);

                    DataTool.Excel2Data(wst, dataConfig);
                }
            }

            MessageBox.Show("导出完毕");
        }

        private void button_ToExcel_Click(object sender, RibbonControlEventArgs e)
        {
            string info = "导入完毕";
            List<string> nofindPath = new List<string>();

            Worksheet config = ExcelTool.GetSheet(Globals.ThisAddIn.Application, DataConfig.c_ConfigSheetName);

            //没有初始化直接返回
            if(config == null)
            {
                return;
            }

            //获取真实路径

            //进行转换
            for (int i = 2; i < config.UsedRange.Rows.Count + 1; i++)
            {
                DataConfig dataConfig = new DataConfig(config, i);

                if (!string.IsNullOrEmpty(dataConfig.m_sheetName) && !string.IsNullOrEmpty(dataConfig.m_txtPath))
                {
                    if(File.Exists(dataConfig.m_txtPath))
                    {
                        Worksheet wst = ExcelTool.GetSheet(Globals.ThisAddIn.Application, dataConfig.m_sheetName, true);
                        DataTool.Data2Excel(dataConfig, wst);
                    }
                    else
                    {
                        nofindPath.Add(dataConfig.m_txtPath);
                    }
                }
            }

            //构造输出信息
            //错误的路径配置
            if(nofindPath.Count > 0)
            {
                info += "\n找不到的文本";
                for (int i = 0; i < nofindPath.Count; i++)
                {
                    info += "\n  " + nofindPath[i];
                }
            }

            MessageBox.Show(info);
        }

       
    }
}
﻿namespace ExcelVstoTool
{
    partial class Ribbon_Main : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon_Main()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDialogLauncher ribbonDialogLauncherImpl1 = this.Factory.CreateRibbonDialogLauncher();
            this.tab_main = this.Factory.CreateRibbonTab();
            this.group_main = this.Factory.CreateRibbonGroup();
            this.button_initConfig = this.Factory.CreateRibbonButton();
            this.button_refreshData = this.Factory.CreateRibbonButton();
            this.checkBox_CloseView = this.Factory.CreateRibbonCheckBox();
            this.checkBox_exportCheck = this.Factory.CreateRibbonCheckBox();
            this.group_file = this.Factory.CreateRibbonGroup();
            this.box_file = this.Factory.CreateRibbonBox();
            this.dropDown_fileList = this.Factory.CreateRibbonDropDown();
            this.button_openFile = this.Factory.CreateRibbonButton();
            this.button_closeFile = this.Factory.CreateRibbonButton();
            this.group_InOut = this.Factory.CreateRibbonGroup();
            this.button_createNewTable = this.Factory.CreateRibbonButton();
            this.button_deleteTable = this.Factory.CreateRibbonButton();
            this.button_ToExcel = this.Factory.CreateRibbonButton();
            this.button_toTxt = this.Factory.CreateRibbonButton();
            this.button_importSingleTable = this.Factory.CreateRibbonButton();
            this.button_exportSingleTable = this.Factory.CreateRibbonButton();
            this.group_Data = this.Factory.CreateRibbonGroup();
            this.button_check = this.Factory.CreateRibbonButton();
            this.button_CreateDataDropDownList = this.Factory.CreateRibbonButton();
            this.button_ClearDropDownList = this.Factory.CreateRibbonButton();
            this.button_generateDataClass = this.Factory.CreateRibbonButton();
            this.dropDown_dataType = this.Factory.CreateRibbonDropDown();
            this.dropDown_assetsType = this.Factory.CreateRibbonDropDown();
            this.dropDown_secType = this.Factory.CreateRibbonDropDown();
            this.group_language = this.Factory.CreateRibbonGroup();
            this.comboBox_currentLanguage = this.Factory.CreateRibbonComboBox();
            this.box_languageFile = this.Factory.CreateRibbonBox();
            this.dropDown_languageFileList = this.Factory.CreateRibbonDropDown();
            this.button_openLanguageFile = this.Factory.CreateRibbonButton();
            this.button_LanguageComment = this.Factory.CreateRibbonButton();
            this.button_deleteLanguageComment = this.Factory.CreateRibbonButton();
            this.button_openLanguageSheet = this.Factory.CreateRibbonButton();
            this.button_changeLanguageColumn = this.Factory.CreateRibbonButton();
            this.button_Replenish = this.Factory.CreateRibbonButton();
            this.button_LanguageInfo = this.Factory.CreateRibbonButton();
            this.group_DataTool = this.Factory.CreateRibbonGroup();
            this.button_ArraryToolWindow = this.Factory.CreateRibbonButton();
            this.button_CompressToolWindow = this.Factory.CreateRibbonButton();
            this.button_FileTool = this.Factory.CreateRibbonButton();
            this.button_ClearData = this.Factory.CreateRibbonButton();
            this.tab_main.SuspendLayout();
            this.group_main.SuspendLayout();
            this.group_file.SuspendLayout();
            this.box_file.SuspendLayout();
            this.group_InOut.SuspendLayout();
            this.group_Data.SuspendLayout();
            this.group_language.SuspendLayout();
            this.box_languageFile.SuspendLayout();
            this.group_DataTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Groups.Add(this.group_main);
            this.tab_main.Groups.Add(this.group_file);
            this.tab_main.Groups.Add(this.group_InOut);
            this.tab_main.Groups.Add(this.group_Data);
            this.tab_main.Groups.Add(this.group_language);
            this.tab_main.Groups.Add(this.group_DataTool);
            this.tab_main.Label = "拓展工具";
            this.tab_main.Name = "tab_main";
            this.tab_main.Position = this.Factory.RibbonPosition.AfterOfficeId("TabHome");
            // 
            // group_main
            // 
            this.group_main.Items.Add(this.button_initConfig);
            this.group_main.Items.Add(this.button_refreshData);
            this.group_main.Items.Add(this.checkBox_CloseView);
            this.group_main.Items.Add(this.checkBox_exportCheck);
            this.group_main.Label = "设置";
            this.group_main.Name = "group_main";
            // 
            // button_initConfig
            // 
            this.button_initConfig.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_initConfig.Label = "设置初始化";
            this.button_initConfig.Name = "button_initConfig";
            this.button_initConfig.OfficeImageId = "TableSharePointListsModifyColumnsAndSettings";
            this.button_initConfig.ShowImage = true;
            this.button_initConfig.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_initData_Click);
            // 
            // button_refreshData
            // 
            this.button_refreshData.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_refreshData.Label = "刷新数据";
            this.button_refreshData.Name = "button_refreshData";
            this.button_refreshData.OfficeImageId = "Refresh";
            this.button_refreshData.ShowImage = true;
            this.button_refreshData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_dataInit_Click);
            // 
            // checkBox_CloseView
            // 
            this.checkBox_CloseView.Checked = true;
            this.checkBox_CloseView.Label = "隐藏窗口以提高效率";
            this.checkBox_CloseView.Name = "checkBox_CloseView";
            // 
            // checkBox_exportCheck
            // 
            this.checkBox_exportCheck.Checked = true;
            this.checkBox_exportCheck.Label = "导出时检验数据有效性";
            this.checkBox_exportCheck.Name = "checkBox_exportCheck";
            // 
            // group_file
            // 
            this.group_file.Items.Add(this.box_file);
            this.group_file.Items.Add(this.button_openFile);
            this.group_file.Items.Add(this.button_closeFile);
            this.group_file.Label = "文件";
            this.group_file.Name = "group_file";
            // 
            // box_file
            // 
            this.box_file.Items.Add(this.dropDown_fileList);
            this.box_file.Name = "box_file";
            // 
            // dropDown_fileList
            // 
            this.dropDown_fileList.Label = "表名";
            this.dropDown_fileList.Name = "dropDown_fileList";
            // 
            // button_openFile
            // 
            this.button_openFile.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_openFile.Label = "打开";
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.OfficeImageId = "FileOpen";
            this.button_openFile.ShowImage = true;
            this.button_openFile.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_openFile_Click);
            // 
            // button_closeFile
            // 
            this.button_closeFile.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_closeFile.Label = "关闭";
            this.button_closeFile.Name = "button_closeFile";
            this.button_closeFile.OfficeImageId = "FileClose";
            this.button_closeFile.ShowImage = true;
            this.button_closeFile.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_closeFile_Click);
            // 
            // group_InOut
            // 
            this.group_InOut.Items.Add(this.button_createNewTable);
            this.group_InOut.Items.Add(this.button_deleteTable);
            this.group_InOut.Items.Add(this.button_ToExcel);
            this.group_InOut.Items.Add(this.button_toTxt);
            this.group_InOut.Items.Add(this.button_importSingleTable);
            this.group_InOut.Items.Add(this.button_exportSingleTable);
            this.group_InOut.Label = "导入导出";
            this.group_InOut.Name = "group_InOut";
            // 
            // button_createNewTable
            // 
            this.button_createNewTable.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_createNewTable.Label = "创建表格";
            this.button_createNewTable.Name = "button_createNewTable";
            this.button_createNewTable.OfficeImageId = "GoToNewRecord";
            this.button_createNewTable.ShowImage = true;
            this.button_createNewTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_CreateNewTable_Click);
            // 
            // button_deleteTable
            // 
            this.button_deleteTable.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_deleteTable.Label = "删除表格";
            this.button_deleteTable.Name = "button_deleteTable";
            this.button_deleteTable.OfficeImageId = "RecordsDeleteRecord";
            this.button_deleteTable.ShowImage = true;
            this.button_deleteTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_deleteTable_Click);
            // 
            // button_ToExcel
            // 
            this.button_ToExcel.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_ToExcel.Label = "全部导入";
            this.button_ToExcel.Name = "button_ToExcel";
            this.button_ToExcel.OfficeImageId = "ImportSavedImports";
            this.button_ToExcel.ShowImage = true;
            this.button_ToExcel.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_ToExcel_Click);
            // 
            // button_toTxt
            // 
            this.button_toTxt.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_toTxt.Label = "全部导出";
            this.button_toTxt.Name = "button_toTxt";
            this.button_toTxt.OfficeImageId = "ExportSavedExports";
            this.button_toTxt.ShowImage = true;
            this.button_toTxt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_toTxt_Click);
            // 
            // button_importSingleTable
            // 
            this.button_importSingleTable.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_importSingleTable.Label = "导入当前表格";
            this.button_importSingleTable.Name = "button_importSingleTable";
            this.button_importSingleTable.OfficeImageId = "ImportTextFile";
            this.button_importSingleTable.ShowImage = true;
            this.button_importSingleTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_importSingleTable_Click);
            // 
            // button_exportSingleTable
            // 
            this.button_exportSingleTable.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_exportSingleTable.Label = "导出当前表格";
            this.button_exportSingleTable.Name = "button_exportSingleTable";
            this.button_exportSingleTable.OfficeImageId = "ExportTextFile";
            this.button_exportSingleTable.ShowImage = true;
            this.button_exportSingleTable.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_exportSingleTable_Click);
            // 
            // group_Data
            // 
            this.group_Data.Items.Add(this.button_check);
            this.group_Data.Items.Add(this.button_CreateDataDropDownList);
            this.group_Data.Items.Add(this.button_ClearDropDownList);
            this.group_Data.Items.Add(this.button_generateDataClass);
            this.group_Data.Items.Add(this.dropDown_dataType);
            this.group_Data.Items.Add(this.dropDown_assetsType);
            this.group_Data.Items.Add(this.dropDown_secType);
            this.group_Data.Label = "数据";
            this.group_Data.Name = "group_Data";
            // 
            // button_check
            // 
            this.button_check.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_check.Label = "数据校验";
            this.button_check.Name = "button_check";
            this.button_check.OfficeImageId = "AcceptInvitation";
            this.button_check.ShowImage = true;
            this.button_check.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_check_Click);
            // 
            // button_CreateDataDropDownList
            // 
            this.button_CreateDataDropDownList.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_CreateDataDropDownList.Label = "生成下拉列表";
            this.button_CreateDataDropDownList.Name = "button_CreateDataDropDownList";
            this.button_CreateDataDropDownList.OfficeImageId = "TablePropertiesDialog";
            this.button_CreateDataDropDownList.ShowImage = true;
            this.button_CreateDataDropDownList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_CreateDataDropDownList_Click);
            // 
            // button_ClearDropDownList
            // 
            this.button_ClearDropDownList.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_ClearDropDownList.Label = "删除下拉列表";
            this.button_ClearDropDownList.Name = "button_ClearDropDownList";
            this.button_ClearDropDownList.OfficeImageId = "TableDeleteRowsAndColumnsMenuWord";
            this.button_ClearDropDownList.ShowImage = true;
            this.button_ClearDropDownList.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_ClearDropDownList_Click);
            // 
            // button_generateDataClass
            // 
            this.button_generateDataClass.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_generateDataClass.Label = "生成数据类";
            this.button_generateDataClass.Name = "button_generateDataClass";
            this.button_generateDataClass.OfficeImageId = "CreateClassModule";
            this.button_generateDataClass.ShowImage = true;
            this.button_generateDataClass.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_generateDataClass_Click);
            // 
            // dropDown_dataType
            // 
            this.dropDown_dataType.Enabled = false;
            this.dropDown_dataType.Label = "数据类型";
            this.dropDown_dataType.Name = "dropDown_dataType";
            this.dropDown_dataType.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown_dataType_SelectionChanged);
            // 
            // dropDown_assetsType
            // 
            this.dropDown_assetsType.Enabled = false;
            this.dropDown_assetsType.Label = "数据用途";
            this.dropDown_assetsType.Name = "dropDown_assetsType";
            this.dropDown_assetsType.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown_assetsType_SelectionChanged);
            // 
            // dropDown_secType
            // 
            this.dropDown_secType.Enabled = false;
            this.dropDown_secType.Label = "次级类型";
            this.dropDown_secType.Name = "dropDown_secType";
            this.dropDown_secType.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.dropDown_secType_SelectionChanged);
            // 
            // group_language
            // 
            this.group_language.Items.Add(this.comboBox_currentLanguage);
            this.group_language.Items.Add(this.box_languageFile);
            this.group_language.Items.Add(this.button_LanguageComment);
            this.group_language.Items.Add(this.button_deleteLanguageComment);
            this.group_language.Items.Add(this.button_openLanguageSheet);
            this.group_language.Items.Add(this.button_changeLanguageColumn);
            this.group_language.Items.Add(this.button_Replenish);
            this.group_language.Items.Add(this.button_LanguageInfo);
            this.group_language.Label = "多语言";
            this.group_language.Name = "group_language";
            // 
            // comboBox_currentLanguage
            // 
            this.comboBox_currentLanguage.Enabled = false;
            this.comboBox_currentLanguage.Label = "当前语言";
            this.comboBox_currentLanguage.Name = "comboBox_currentLanguage";
            this.comboBox_currentLanguage.ShowItemImage = false;
            this.comboBox_currentLanguage.Text = null;
            this.comboBox_currentLanguage.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.comboBox_currentLanguage_TextChanged);
            // 
            // box_languageFile
            // 
            this.box_languageFile.Items.Add(this.dropDown_languageFileList);
            this.box_languageFile.Items.Add(this.button_openLanguageFile);
            this.box_languageFile.Name = "box_languageFile";
            // 
            // dropDown_languageFileList
            // 
            this.dropDown_languageFileList.Label = "多语言名";
            this.dropDown_languageFileList.Name = "dropDown_languageFileList";
            // 
            // button_openLanguageFile
            // 
            this.button_openLanguageFile.Label = "button1";
            this.button_openLanguageFile.Name = "button_openLanguageFile";
            this.button_openLanguageFile.OfficeImageId = "FileOpen";
            this.button_openLanguageFile.ShowImage = true;
            this.button_openLanguageFile.ShowLabel = false;
            this.button_openLanguageFile.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_openLanguageFile_Click);
            // 
            // button_LanguageComment
            // 
            this.button_LanguageComment.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_LanguageComment.Enabled = false;
            this.button_LanguageComment.Label = "多语言批注";
            this.button_LanguageComment.Name = "button_LanguageComment";
            this.button_LanguageComment.OfficeImageId = "ReviewEditComment";
            this.button_LanguageComment.ShowImage = true;
            this.button_LanguageComment.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_LanguageComment_Click);
            // 
            // button_deleteLanguageComment
            // 
            this.button_deleteLanguageComment.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_deleteLanguageComment.Enabled = false;
            this.button_deleteLanguageComment.Label = "删除批注";
            this.button_deleteLanguageComment.Name = "button_deleteLanguageComment";
            this.button_deleteLanguageComment.OfficeImageId = "ReviewDeleteComment";
            this.button_deleteLanguageComment.ShowImage = true;
            this.button_deleteLanguageComment.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_deleteLanguageComment_Click);
            // 
            // button_openLanguageSheet
            // 
            this.button_openLanguageSheet.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_openLanguageSheet.Enabled = false;
            this.button_openLanguageSheet.Label = "打开多语言文件";
            this.button_openLanguageSheet.Name = "button_openLanguageSheet";
            this.button_openLanguageSheet.OfficeImageId = "FilePrintPreview";
            this.button_openLanguageSheet.ShowImage = true;
            this.button_openLanguageSheet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_openLanguageSheet_Click);
            // 
            // button_changeLanguageColumn
            // 
            this.button_changeLanguageColumn.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_changeLanguageColumn.Enabled = false;
            this.button_changeLanguageColumn.Label = "转化为多语言";
            this.button_changeLanguageColumn.Name = "button_changeLanguageColumn";
            this.button_changeLanguageColumn.OfficeImageId = "SetLanguage";
            this.button_changeLanguageColumn.ShowImage = true;
            this.button_changeLanguageColumn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_changeLanguageColumn_Click);
            // 
            // button_Replenish
            // 
            this.button_Replenish.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_Replenish.Label = "补充多语言";
            this.button_Replenish.Name = "button_Replenish";
            this.button_Replenish.ShowImage = true;
            this.button_Replenish.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_Replenish_Click);
            // 
            // button_LanguageInfo
            // 
            this.button_LanguageInfo.Label = "帮助";
            this.button_LanguageInfo.Name = "button_LanguageInfo";
            this.button_LanguageInfo.OfficeImageId = "Help";
            this.button_LanguageInfo.ShowImage = true;
            this.button_LanguageInfo.ShowLabel = false;
            this.button_LanguageInfo.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_LanguageInfo_Click);
            // 
            // group_DataTool
            // 
            this.group_DataTool.DialogLauncher = ribbonDialogLauncherImpl1;
            this.group_DataTool.Items.Add(this.button_ArraryToolWindow);
            this.group_DataTool.Items.Add(this.button_CompressToolWindow);
            this.group_DataTool.Items.Add(this.button_FileTool);
            this.group_DataTool.Items.Add(this.button_ClearData);
            this.group_DataTool.Label = "工具";
            this.group_DataTool.Name = "group_DataTool";
            // 
            // button_ArraryToolWindow
            // 
            this.button_ArraryToolWindow.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_ArraryToolWindow.Label = "数组操作";
            this.button_ArraryToolWindow.Name = "button_ArraryToolWindow";
            this.button_ArraryToolWindow.OfficeImageId = "OutlineGroup";
            this.button_ArraryToolWindow.ShowImage = true;
            this.button_ArraryToolWindow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_ArraryToolWindow_Click);
            // 
            // button_CompressToolWindow
            // 
            this.button_CompressToolWindow.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_CompressToolWindow.Label = "数据操作";
            this.button_CompressToolWindow.Name = "button_CompressToolWindow";
            this.button_CompressToolWindow.OfficeImageId = "Consolidate";
            this.button_CompressToolWindow.ShowImage = true;
            this.button_CompressToolWindow.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_CompressToolWindow_Click);
            // 
            // button_FileTool
            // 
            this.button_FileTool.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_FileTool.Label = "文件操作";
            this.button_FileTool.Name = "button_FileTool";
            this.button_FileTool.OfficeImageId = "FileManageMenu";
            this.button_FileTool.ShowImage = true;
            this.button_FileTool.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_FileTool_Click);
            // 
            // button_ClearData
            // 
            this.button_ClearData.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_ClearData.Label = "清理数据";
            this.button_ClearData.Name = "button_ClearData";
            this.button_ClearData.OfficeImageId = "TableStyleClear";
            this.button_ClearData.ShowImage = true;
            this.button_ClearData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_ClearData_Click);
            // 
            // Ribbon_Main
            // 
            this.Name = "Ribbon_Main";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab_main);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Main_Load);
            this.tab_main.ResumeLayout(false);
            this.tab_main.PerformLayout();
            this.group_main.ResumeLayout(false);
            this.group_main.PerformLayout();
            this.group_file.ResumeLayout(false);
            this.group_file.PerformLayout();
            this.box_file.ResumeLayout(false);
            this.box_file.PerformLayout();
            this.group_InOut.ResumeLayout(false);
            this.group_InOut.PerformLayout();
            this.group_Data.ResumeLayout(false);
            this.group_Data.PerformLayout();
            this.group_language.ResumeLayout(false);
            this.group_language.PerformLayout();
            this.box_languageFile.ResumeLayout(false);
            this.box_languageFile.PerformLayout();
            this.group_DataTool.ResumeLayout(false);
            this.group_DataTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab_main;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_main;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_InOut;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_toTxt;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_ToExcel;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_initConfig;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox_CloseView;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBox_exportCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_Data;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_check;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_language;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_changeLanguageColumn;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox comboBox_currentLanguage;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_LanguageInfo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_refreshData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_openLanguageSheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_LanguageComment;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_deleteLanguageComment;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_dataType;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_assetsType;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_secType;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_generateDataClass;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_CreateDataDropDownList;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_ClearDropDownList;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_createNewTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_deleteTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_exportSingleTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_importSingleTable;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_file;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_fileList;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_openFile;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_closeFile;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box_languageFile;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDown_languageFileList;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_openLanguageFile;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box_file;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group_DataTool;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_ArraryToolWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_CompressToolWindow;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_FileTool;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_ClearData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_Replenish;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon_Main Ribbon_Main
        {
            get { return this.GetRibbon<Ribbon_Main>(); }
        }
    }
}

﻿namespace ExcelVstoTool.DialogWindow
{
    partial class CompressToolWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_TargetRange = new System.Windows.Forms.RadioButton();
            this.textBox_selectRange = new System.Windows.Forms.TextBox();
            this.textBox_targetRange = new System.Windows.Forms.TextBox();
            this.label_sheetName = new System.Windows.Forms.Label();
            this.label_targetRange = new System.Windows.Forms.Label();
            this.radioButton_SelectRange = new System.Windows.Forms.RadioButton();
            this.button_CompressAndExtract = new System.Windows.Forms.Button();
            this.button_Compress = new System.Windows.Forms.Button();
            this.helpProvider_tool = new System.Windows.Forms.HelpProvider();
            this.button_saveData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_TargetRange
            // 
            this.radioButton_TargetRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_TargetRange.AutoSize = true;
            this.radioButton_TargetRange.Location = new System.Drawing.Point(303, 47);
            this.radioButton_TargetRange.Name = "radioButton_TargetRange";
            this.radioButton_TargetRange.Size = new System.Drawing.Size(14, 13);
            this.radioButton_TargetRange.TabIndex = 12;
            this.radioButton_TargetRange.UseVisualStyleBackColor = true;
            this.radioButton_TargetRange.CheckedChanged += new System.EventHandler(this.radioButton_TargetRange_CheckedChanged);
            // 
            // textBox_selectRange
            // 
            this.textBox_selectRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_selectRange.Location = new System.Drawing.Point(70, 12);
            this.textBox_selectRange.Name = "textBox_selectRange";
            this.textBox_selectRange.Size = new System.Drawing.Size(215, 21);
            this.textBox_selectRange.TabIndex = 10;
            // 
            // textBox_targetRange
            // 
            this.textBox_targetRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_targetRange.Location = new System.Drawing.Point(70, 43);
            this.textBox_targetRange.Name = "textBox_targetRange";
            this.textBox_targetRange.Size = new System.Drawing.Size(215, 21);
            this.textBox_targetRange.TabIndex = 11;
            // 
            // label_sheetName
            // 
            this.label_sheetName.AutoSize = true;
            this.label_sheetName.Location = new System.Drawing.Point(11, 15);
            this.label_sheetName.Name = "label_sheetName";
            this.label_sheetName.Size = new System.Drawing.Size(53, 12);
            this.label_sheetName.TabIndex = 8;
            this.label_sheetName.Text = "选中区域";
            // 
            // label_targetRange
            // 
            this.label_targetRange.AutoSize = true;
            this.label_targetRange.Location = new System.Drawing.Point(11, 47);
            this.label_targetRange.Name = "label_targetRange";
            this.label_targetRange.Size = new System.Drawing.Size(53, 12);
            this.label_targetRange.TabIndex = 9;
            this.label_targetRange.Text = "目标区域";
            // 
            // radioButton_SelectRange
            // 
            this.radioButton_SelectRange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_SelectRange.AutoSize = true;
            this.radioButton_SelectRange.Checked = true;
            this.radioButton_SelectRange.Location = new System.Drawing.Point(303, 15);
            this.radioButton_SelectRange.Name = "radioButton_SelectRange";
            this.radioButton_SelectRange.Size = new System.Drawing.Size(14, 13);
            this.radioButton_SelectRange.TabIndex = 13;
            this.radioButton_SelectRange.TabStop = true;
            this.radioButton_SelectRange.UseVisualStyleBackColor = true;
            this.radioButton_SelectRange.CheckedChanged += new System.EventHandler(this.radioButton_SelectRange_CheckedChanged);
            // 
            // button_CompressAndExtract
            // 
            this.button_CompressAndExtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CompressAndExtract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_CompressAndExtract.Location = new System.Drawing.Point(7, 358);
            this.button_CompressAndExtract.Name = "button_CompressAndExtract";
            this.button_CompressAndExtract.Size = new System.Drawing.Size(310, 23);
            this.button_CompressAndExtract.TabIndex = 14;
            this.button_CompressAndExtract.Text = "压缩并提取";
            this.button_CompressAndExtract.UseVisualStyleBackColor = true;
            this.button_CompressAndExtract.Click += new System.EventHandler(this.button_CompressAndExtract_Click);
            // 
            // button_Compress
            // 
            this.button_Compress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Compress.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Compress.Location = new System.Drawing.Point(7, 387);
            this.button_Compress.Name = "button_Compress";
            this.button_Compress.Size = new System.Drawing.Size(310, 23);
            this.button_Compress.TabIndex = 15;
            this.button_Compress.Text = "压缩数据";
            this.button_Compress.UseVisualStyleBackColor = true;
            this.button_Compress.Click += new System.EventHandler(this.button_Compress_Click);
            // 
            // button_saveData
            // 
            this.button_saveData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_saveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_saveData.Location = new System.Drawing.Point(7, 416);
            this.button_saveData.Name = "button_saveData";
            this.button_saveData.Size = new System.Drawing.Size(310, 23);
            this.button_saveData.TabIndex = 16;
            this.button_saveData.Text = "转换为计算结果";
            this.button_saveData.UseVisualStyleBackColor = true;
            this.button_saveData.Click += new System.EventHandler(this.button_saveData_Click);
            // 
            // CompressToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 451);
            this.Controls.Add(this.button_saveData);
            this.Controls.Add(this.button_Compress);
            this.Controls.Add(this.button_CompressAndExtract);
            this.Controls.Add(this.radioButton_SelectRange);
            this.Controls.Add(this.radioButton_TargetRange);
            this.Controls.Add(this.textBox_selectRange);
            this.Controls.Add(this.textBox_targetRange);
            this.Controls.Add(this.label_sheetName);
            this.Controls.Add(this.label_targetRange);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "CompressToolWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "数据压缩工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_TargetRange;
        private System.Windows.Forms.TextBox textBox_selectRange;
        private System.Windows.Forms.TextBox textBox_targetRange;
        private System.Windows.Forms.Label label_sheetName;
        private System.Windows.Forms.Label label_targetRange;
        private System.Windows.Forms.RadioButton radioButton_SelectRange;
        private System.Windows.Forms.Button button_CompressAndExtract;
        private System.Windows.Forms.Button button_Compress;
        private System.Windows.Forms.HelpProvider helpProvider_tool;
        private System.Windows.Forms.Button button_saveData;
    }
}
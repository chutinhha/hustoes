﻿namespace OES.UPanel
{
    partial class AddWord
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.buttonTestPoint = new System.Windows.Forms.Button();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textOriWord = new System.Windows.Forms.TextBox();
            this.btnAnsSel = new System.Windows.Forms.Button();
            this.labelOriWord = new System.Windows.Forms.Label();
            this.btnOriSel = new System.Windows.Forms.Button();
            this.labelAnsWord = new System.Windows.Forms.Label();
            this.textAnsWord = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnXmlSel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textXmlWord = new System.Windows.Forms.TextBox();
            this.groupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.textXmlWord);
            this.groupInfo.Controls.Add(this.btnXmlSel);
            this.groupInfo.Controls.Add(this.label1);
            this.groupInfo.Controls.Add(this.buttonTestPoint);
            this.groupInfo.Controls.Add(this.textInfo);
            this.groupInfo.Controls.Add(this.labelInfo);
            this.groupInfo.Controls.Add(this.textOriWord);
            this.groupInfo.Controls.Add(this.btnAnsSel);
            this.groupInfo.Controls.Add(this.labelOriWord);
            this.groupInfo.Controls.Add(this.btnOriSel);
            this.groupInfo.Controls.Add(this.labelAnsWord);
            this.groupInfo.Controls.Add(this.textAnsWord);
            this.groupInfo.Location = new System.Drawing.Point(12, 3);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(715, 472);
            this.groupInfo.TabIndex = 8;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Word文件/路径信息";
            // 
            // buttonTestPoint
            // 
            this.buttonTestPoint.Location = new System.Drawing.Point(116, 101);
            this.buttonTestPoint.Name = "buttonTestPoint";
            this.buttonTestPoint.Size = new System.Drawing.Size(412, 38);
            this.buttonTestPoint.TabIndex = 9;
            this.buttonTestPoint.Text = "点此建立新考点";
            this.buttonTestPoint.UseVisualStyleBackColor = true;
            this.buttonTestPoint.Click += new System.EventHandler(this.buttonTestPoint_Click);
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(116, 145);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInfo.Size = new System.Drawing.Size(412, 232);
            this.textInfo.TabIndex = 8;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(40, 145);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(53, 12);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "题干描述";
            // 
            // textOriWord
            // 
            this.textOriWord.Location = new System.Drawing.Point(116, 20);
            this.textOriWord.Name = "textOriWord";
            this.textOriWord.Size = new System.Drawing.Size(412, 21);
            this.textOriWord.TabIndex = 3;
            this.textOriWord.Text = "F:\\点维工作室\\testStu.doc";
            // 
            // btnAnsSel
            // 
            this.btnAnsSel.Location = new System.Drawing.Point(546, 45);
            this.btnAnsSel.Name = "btnAnsSel";
            this.btnAnsSel.Size = new System.Drawing.Size(75, 23);
            this.btnAnsSel.TabIndex = 6;
            this.btnAnsSel.Text = "浏览...";
            this.btnAnsSel.UseVisualStyleBackColor = true;
            this.btnAnsSel.Click += new System.EventHandler(this.btnAnsSel_Click);
            // 
            // labelOriWord
            // 
            this.labelOriWord.AutoSize = true;
            this.labelOriWord.Location = new System.Drawing.Point(32, 24);
            this.labelOriWord.Name = "labelOriWord";
            this.labelOriWord.Size = new System.Drawing.Size(77, 12);
            this.labelOriWord.TabIndex = 1;
            this.labelOriWord.Text = "初始Word文件";
            // 
            // btnOriSel
            // 
            this.btnOriSel.Location = new System.Drawing.Point(546, 18);
            this.btnOriSel.Name = "btnOriSel";
            this.btnOriSel.Size = new System.Drawing.Size(75, 23);
            this.btnOriSel.TabIndex = 5;
            this.btnOriSel.Text = "浏览...";
            this.btnOriSel.UseVisualStyleBackColor = true;
            this.btnOriSel.Click += new System.EventHandler(this.btnOriSel_Click);
            // 
            // labelAnsWord
            // 
            this.labelAnsWord.AutoSize = true;
            this.labelAnsWord.Location = new System.Drawing.Point(32, 51);
            this.labelAnsWord.Name = "labelAnsWord";
            this.labelAnsWord.Size = new System.Drawing.Size(77, 12);
            this.labelAnsWord.TabIndex = 2;
            this.labelAnsWord.Text = "标答Word文件";
            // 
            // textAnsWord
            // 
            this.textAnsWord.Location = new System.Drawing.Point(116, 47);
            this.textAnsWord.Name = "textAnsWord";
            this.textAnsWord.Size = new System.Drawing.Size(412, 21);
            this.textAnsWord.TabIndex = 4;
            this.textAnsWord.Text = "F:\\点维工作室\\testAns.doc";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(634, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(535, 503);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 30);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "保存试题";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnXmlSel
            // 
            this.btnXmlSel.Location = new System.Drawing.Point(546, 72);
            this.btnXmlSel.Name = "btnXmlSel";
            this.btnXmlSel.Size = new System.Drawing.Size(75, 23);
            this.btnXmlSel.TabIndex = 12;
            this.btnXmlSel.Text = "浏览...";
            this.btnXmlSel.UseVisualStyleBackColor = true;
            this.btnXmlSel.Click += new System.EventHandler(this.btnXmlSel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "考点xml文件";
            // 
            // textXmlWord
            // 
            this.textXmlWord.Location = new System.Drawing.Point(116, 74);
            this.textXmlWord.Name = "textXmlWord";
            this.textXmlWord.Size = new System.Drawing.Size(412, 21);
            this.textXmlWord.TabIndex = 13;
            this.textXmlWord.Text = "F:\\点维工作室\\testAns.xml";
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupInfo);
            this.Name = "AddWord";
            this.Size = new System.Drawing.Size(742, 553);
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Button buttonTestPoint;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textOriWord;
        private System.Windows.Forms.Button btnAnsSel;
        private System.Windows.Forms.Label labelOriWord;
        private System.Windows.Forms.Button btnOriSel;
        private System.Windows.Forms.Label labelAnsWord;
        private System.Windows.Forms.TextBox textAnsWord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnXmlSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textXmlWord;
    }
}

﻿namespace OES.UControl
{
    partial class StudentAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioAddOne = new System.Windows.Forms.RadioButton();
            this.radioAddMany = new System.Windows.Forms.RadioButton();
            this.groupAddOne = new System.Windows.Forms.GroupBox();
            this.comboOneClass = new System.Windows.Forms.ComboBox();
            this.comboOneDept = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textPW2 = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupAddMany = new System.Windows.Forms.GroupBox();
            this.comboManyClass = new System.Windows.Forms.ComboBox();
            this.comboManyDept = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.textDept = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddMany = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.groupAddOne.SuspendLayout();
            this.groupAddMany.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "学院名称：";
            // 
            // radioAddOne
            // 
            this.radioAddOne.AutoSize = true;
            this.radioAddOne.Location = new System.Drawing.Point(51, 15);
            this.radioAddOne.Name = "radioAddOne";
            this.radioAddOne.Size = new System.Drawing.Size(122, 20);
            this.radioAddOne.TabIndex = 1;
            this.radioAddOne.TabStop = true;
            this.radioAddOne.Text = "添加单个学生";
            this.radioAddOne.UseVisualStyleBackColor = true;
            this.radioAddOne.CheckedChanged += new System.EventHandler(this.radioAddOne_CheckedChanged);
            // 
            // radioAddMany
            // 
            this.radioAddMany.AutoSize = true;
            this.radioAddMany.Location = new System.Drawing.Point(51, 241);
            this.radioAddMany.Name = "radioAddMany";
            this.radioAddMany.Size = new System.Drawing.Size(154, 20);
            this.radioAddMany.TabIndex = 2;
            this.radioAddMany.TabStop = true;
            this.radioAddMany.Text = "批量导入班级学生";
            this.radioAddMany.UseVisualStyleBackColor = true;
            this.radioAddMany.CheckedChanged += new System.EventHandler(this.radioAddMany_CheckedChanged);
            // 
            // groupAddOne
            // 
            this.groupAddOne.Controls.Add(this.comboOneClass);
            this.groupAddOne.Controls.Add(this.comboOneDept);
            this.groupAddOne.Controls.Add(this.label9);
            this.groupAddOne.Controls.Add(this.label10);
            this.groupAddOne.Controls.Add(this.btnAddOne);
            this.groupAddOne.Controls.Add(this.textID);
            this.groupAddOne.Controls.Add(this.textPW2);
            this.groupAddOne.Controls.Add(this.textName);
            this.groupAddOne.Controls.Add(this.textPW);
            this.groupAddOne.Controls.Add(this.label6);
            this.groupAddOne.Controls.Add(this.label5);
            this.groupAddOne.Controls.Add(this.label4);
            this.groupAddOne.Controls.Add(this.label3);
            this.groupAddOne.Controls.Add(this.label2);
            this.groupAddOne.Location = new System.Drawing.Point(62, 41);
            this.groupAddOne.Name = "groupAddOne";
            this.groupAddOne.Size = new System.Drawing.Size(557, 173);
            this.groupAddOne.TabIndex = 4;
            this.groupAddOne.TabStop = false;
            this.groupAddOne.Text = "学生信息";
            // 
            // comboOneClass
            // 
            this.comboOneClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOneClass.FormattingEnabled = true;
            this.comboOneClass.Location = new System.Drawing.Point(339, 55);
            this.comboOneClass.Name = "comboOneClass";
            this.comboOneClass.Size = new System.Drawing.Size(190, 24);
            this.comboOneClass.TabIndex = 10;
            // 
            // comboOneDept
            // 
            this.comboOneDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOneDept.FormattingEnabled = true;
            this.comboOneDept.Location = new System.Drawing.Point(117, 56);
            this.comboOneDept.Name = "comboOneDept";
            this.comboOneDept.Size = new System.Drawing.Size(133, 24);
            this.comboOneDept.TabIndex = 9;
            this.comboOneDept.TextChanged += new System.EventHandler(this.comboOneDept_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "所在班级：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "所在学院：";
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(413, 128);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(81, 29);
            this.btnAddOne.TabIndex = 13;
            this.btnAddOne.Text = "添加学生";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(339, 18);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(190, 26);
            this.textID.TabIndex = 8;
            // 
            // textPW2
            // 
            this.textPW2.Location = new System.Drawing.Point(117, 130);
            this.textPW2.Name = "textPW2";
            this.textPW2.PasswordChar = '*';
            this.textPW2.Size = new System.Drawing.Size(133, 26);
            this.textPW2.TabIndex = 12;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(117, 18);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(133, 26);
            this.textName.TabIndex = 6;
            // 
            // textPW
            // 
            this.textPW.Location = new System.Drawing.Point(117, 90);
            this.textPW.Name = "textPW";
            this.textPW.PasswordChar = '*';
            this.textPW.Size = new System.Drawing.Size(133, 26);
            this.textPW.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "再输入一次：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "（若不填密码，则新密码为该生学号）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "学生姓名：";
            // 
            // groupAddMany
            // 
            this.groupAddMany.Controls.Add(this.comboManyClass);
            this.groupAddMany.Controls.Add(this.comboManyDept);
            this.groupAddMany.Controls.Add(this.label11);
            this.groupAddMany.Controls.Add(this.textClass);
            this.groupAddMany.Controls.Add(this.textDept);
            this.groupAddMany.Controls.Add(this.label8);
            this.groupAddMany.Controls.Add(this.btnAddMany);
            this.groupAddMany.Controls.Add(this.btnBrowse);
            this.groupAddMany.Controls.Add(this.textFile);
            this.groupAddMany.Controls.Add(this.label7);
            this.groupAddMany.Controls.Add(this.label1);
            this.groupAddMany.Location = new System.Drawing.Point(62, 267);
            this.groupAddMany.Name = "groupAddMany";
            this.groupAddMany.Size = new System.Drawing.Size(557, 150);
            this.groupAddMany.TabIndex = 5;
            this.groupAddMany.TabStop = false;
            this.groupAddMany.Text = "导入文件";
            // 
            // comboManyClass
            // 
            this.comboManyClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboManyClass.FormattingEnabled = true;
            this.comboManyClass.Location = new System.Drawing.Point(339, 31);
            this.comboManyClass.Name = "comboManyClass";
            this.comboManyClass.Size = new System.Drawing.Size(190, 24);
            this.comboManyClass.TabIndex = 16;
            this.comboManyClass.Visible = false;
            // 
            // comboManyDept
            // 
            this.comboManyDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboManyDept.FormattingEnabled = true;
            this.comboManyDept.Location = new System.Drawing.Point(98, 31);
            this.comboManyDept.Name = "comboManyDept";
            this.comboManyDept.Size = new System.Drawing.Size(133, 24);
            this.comboManyDept.TabIndex = 16;
            this.comboManyDept.Visible = false;
            this.comboManyDept.SelectedIndexChanged += new System.EventHandler(this.comboManyDept_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(360, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "注意：学生信息包括学生姓名、学号以及密码信息";
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(339, 31);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(190, 26);
            this.textClass.TabIndex = 18;
            // 
            // textDept
            // 
            this.textDept.Location = new System.Drawing.Point(98, 29);
            this.textDept.Name = "textDept";
            this.textDept.Size = new System.Drawing.Size(133, 26);
            this.textDept.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "班级名称：";
            // 
            // btnAddMany
            // 
            this.btnAddMany.Location = new System.Drawing.Point(413, 105);
            this.btnAddMany.Name = "btnAddMany";
            this.btnAddMany.Size = new System.Drawing.Size(75, 28);
            this.btnAddMany.TabIndex = 22;
            this.btnAddMany.Text = "导入";
            this.btnAddMany.UseVisualStyleBackColor = true;
            this.btnAddMany.Click += new System.EventHandler(this.btnAddMany_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(456, 69);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 28);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(160, 69);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(290, 26);
            this.textFile.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "学生信息文件地址：";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(518, 429);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 32);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // StudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.groupAddMany);
            this.Controls.Add(this.groupAddOne);
            this.Controls.Add(this.radioAddMany);
            this.Controls.Add(this.radioAddOne);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentAdd";
            this.Size = new System.Drawing.Size(710, 510);
            this.groupAddOne.ResumeLayout(false);
            this.groupAddOne.PerformLayout();
            this.groupAddMany.ResumeLayout(false);
            this.groupAddMany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioAddOne;
        private System.Windows.Forms.RadioButton radioAddMany;
        private System.Windows.Forms.GroupBox groupAddOne;
        private System.Windows.Forms.GroupBox groupAddMany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPW2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAddMany;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboOneClass;
        private System.Windows.Forms.ComboBox comboOneDept;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.TextBox textDept;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboManyClass;
        private System.Windows.Forms.ComboBox comboManyDept;
    }
}
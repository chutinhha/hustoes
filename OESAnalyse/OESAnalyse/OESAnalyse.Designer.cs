﻿namespace OESAnalyse
{
    partial class OESAnalyse
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBut = new System.Windows.Forms.Button();
            this.ScoreDistriBut = new System.Windows.Forms.Button();
            this.CorrectBut = new System.Windows.Forms.Button();
            this.ConfigBut = new System.Windows.Forms.Button();
            this.ExcelBut = new System.Windows.Forms.Button();
            this.btnLookPaper = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PaperCombo = new System.Windows.Forms.ComboBox();
            this.OrderCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(463, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClassCombo
            // 
            this.ClassCombo.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassCombo.Enabled = false;
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Location = new System.Drawing.Point(269, 39);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(89, 20);
            this.ClassCombo.TabIndex = 1;
            this.ClassCombo.SelectedIndexChanged += new System.EventHandler(this.ClassCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(222, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "班级：";
            // 
            // PathBut
            // 
            this.PathBut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PathBut.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathBut.ForeColor = System.Drawing.Color.LightGray;
            this.PathBut.Location = new System.Drawing.Point(549, 89);
            this.PathBut.Name = "PathBut";
            this.PathBut.Size = new System.Drawing.Size(84, 32);
            this.PathBut.TabIndex = 3;
            this.PathBut.Text = "选择路径";
            this.PathBut.UseVisualStyleBackColor = false;
            this.PathBut.Click += new System.EventHandler(this.PathBut_Click);
            // 
            // ScoreDistriBut
            // 
            this.ScoreDistriBut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ScoreDistriBut.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.ScoreDistriBut.ForeColor = System.Drawing.Color.LightGray;
            this.ScoreDistriBut.Location = new System.Drawing.Point(549, 165);
            this.ScoreDistriBut.Name = "ScoreDistriBut";
            this.ScoreDistriBut.Size = new System.Drawing.Size(84, 32);
            this.ScoreDistriBut.TabIndex = 4;
            this.ScoreDistriBut.Text = "成绩分布";
            this.ScoreDistriBut.UseVisualStyleBackColor = false;
            this.ScoreDistriBut.Click += new System.EventHandler(this.ScoreDistriBut_Click);
            // 
            // CorrectBut
            // 
            this.CorrectBut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CorrectBut.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.CorrectBut.ForeColor = System.Drawing.Color.LightGray;
            this.CorrectBut.Location = new System.Drawing.Point(549, 203);
            this.CorrectBut.Name = "CorrectBut";
            this.CorrectBut.Size = new System.Drawing.Size(84, 32);
            this.CorrectBut.TabIndex = 5;
            this.CorrectBut.Text = "题目正确率";
            this.CorrectBut.UseVisualStyleBackColor = false;
            this.CorrectBut.Click += new System.EventHandler(this.CorrectBut_Click);
            // 
            // ConfigBut
            // 
            this.ConfigBut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ConfigBut.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.ConfigBut.ForeColor = System.Drawing.Color.LightGray;
            this.ConfigBut.Location = new System.Drawing.Point(549, 241);
            this.ConfigBut.Name = "ConfigBut";
            this.ConfigBut.Size = new System.Drawing.Size(84, 32);
            this.ConfigBut.TabIndex = 6;
            this.ConfigBut.Text = "配置";
            this.ConfigBut.UseVisualStyleBackColor = false;
            this.ConfigBut.Click += new System.EventHandler(this.ConfigBut_Click);
            // 
            // ExcelBut
            // 
            this.ExcelBut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ExcelBut.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.ExcelBut.ForeColor = System.Drawing.Color.LightGray;
            this.ExcelBut.Location = new System.Drawing.Point(549, 279);
            this.ExcelBut.Name = "ExcelBut";
            this.ExcelBut.Size = new System.Drawing.Size(84, 32);
            this.ExcelBut.TabIndex = 7;
            this.ExcelBut.Text = "导出Excel";
            this.ExcelBut.UseVisualStyleBackColor = false;
            this.ExcelBut.Click += new System.EventHandler(this.ExcelBut_Click);
            // 
            // btnLookPaper
            // 
            this.btnLookPaper.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLookPaper.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.btnLookPaper.ForeColor = System.Drawing.Color.LightGray;
            this.btnLookPaper.Location = new System.Drawing.Point(549, 127);
            this.btnLookPaper.Name = "btnLookPaper";
            this.btnLookPaper.Size = new System.Drawing.Size(84, 32);
            this.btnLookPaper.TabIndex = 8;
            this.btnLookPaper.Text = "查看试卷";
            this.btnLookPaper.UseVisualStyleBackColor = false;
            this.btnLookPaper.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(378, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "试卷：";
            // 
            // PaperCombo
            // 
            this.PaperCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaperCombo.Enabled = false;
            this.PaperCombo.FormattingEnabled = true;
            this.PaperCombo.Location = new System.Drawing.Point(425, 39);
            this.PaperCombo.Name = "PaperCombo";
            this.PaperCombo.Size = new System.Drawing.Size(83, 20);
            this.PaperCombo.TabIndex = 10;
            this.PaperCombo.SelectedIndexChanged += new System.EventHandler(this.PaperCombo_SelectedIndexChanged_1);
            // 
            // OrderCombo
            // 
            this.OrderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderCombo.FormattingEnabled = true;
            this.OrderCombo.Items.AddRange(new object[] {
            "先班级",
            "先试卷"});
            this.OrderCombo.Location = new System.Drawing.Point(114, 39);
            this.OrderCombo.Name = "OrderCombo";
            this.OrderCombo.Size = new System.Drawing.Size(89, 20);
            this.OrderCombo.TabIndex = 11;
            this.OrderCombo.SelectedIndexChanged += new System.EventHandler(this.OrderCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "选择顺序：";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(593, 299);
            this.dataGridView2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.backButn);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 368);
            this.panel1.TabIndex = 13;
            // 
            // backButn
            // 
            this.backButn.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.backButn.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold);
            this.backButn.ForeColor = System.Drawing.Color.LightGray;
            this.backButn.Location = new System.Drawing.Point(527, 317);
            this.backButn.Name = "backButn";
            this.backButn.Size = new System.Drawing.Size(81, 30);
            this.backButn.TabIndex = 1;
            this.backButn.Text = "返回";
            this.backButn.UseVisualStyleBackColor = false;
            this.backButn.Click += new System.EventHandler(this.backButn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(656, 303);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(45, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 30);
            this.button1.TabIndex = 2;
            this.button1.Tag = "";
            this.button1.Text = "导出试题";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OESAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 368);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLookPaper);
            this.Controls.Add(this.OrderCombo);
            this.Controls.Add(this.ScoreDistriBut);
            this.Controls.Add(this.PaperCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExcelBut);
            this.Controls.Add(this.ConfigBut);
            this.Controls.Add(this.CorrectBut);
            this.Controls.Add(this.PathBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassCombo);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "OESAnalyse";
            this.Text = "Analyse";
            this.Load += new System.EventHandler(this.OESAnalyse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PathBut;
        private System.Windows.Forms.Button ScoreDistriBut;
        private System.Windows.Forms.Button CorrectBut;
        private System.Windows.Forms.Button ConfigBut;
        private System.Windows.Forms.Button ExcelBut;
        private System.Windows.Forms.Button btnLookPaper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PaperCombo;
        private System.Windows.Forms.ComboBox OrderCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button1;
    }
}


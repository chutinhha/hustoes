﻿namespace OES
{
    partial class AddQuetionPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuetionPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCapater = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDifficultyValue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQueStyle = new System.Windows.Forms.ComboBox();
            this.plAddQuestion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbCapater
            // 
            this.cbCapater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCapater.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCapater.FormattingEnabled = true;
            this.cbCapater.Location = new System.Drawing.Point(56, 83);
            this.cbCapater.Name = "cbCapater";
            this.cbCapater.Size = new System.Drawing.Size(108, 24);
            this.cbCapater.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "章节";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(180, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "难度";
            // 
            // cbDifficultyValue
            // 
            this.cbDifficultyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDifficultyValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbDifficultyValue.FormattingEnabled = true;
            this.cbDifficultyValue.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDifficultyValue.Location = new System.Drawing.Point(233, 83);
            this.cbDifficultyValue.Name = "cbDifficultyValue";
            this.cbDifficultyValue.Size = new System.Drawing.Size(111, 24);
            this.cbDifficultyValue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(374, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "试题类型";
            // 
            // cbQueStyle
            // 
            this.cbQueStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbQueStyle.FormattingEnabled = true;
            this.cbQueStyle.Location = new System.Drawing.Point(465, 83);
            this.cbQueStyle.Name = "cbQueStyle";
            this.cbQueStyle.Size = new System.Drawing.Size(132, 24);
            this.cbQueStyle.TabIndex = 6;
            this.cbQueStyle.TextChanged += new System.EventHandler(this.cbQueStyle_TextChanged);
            // 
            // plAddQuestion
            // 
            this.plAddQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plAddQuestion.Location = new System.Drawing.Point(0, 113);
            this.plAddQuestion.Name = "plAddQuestion";
            this.plAddQuestion.Size = new System.Drawing.Size(742, 553);
            this.plAddQuestion.TabIndex = 7;
            // 
            // AddQuetionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.plAddQuestion);
            this.Controls.Add(this.cbQueStyle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDifficultyValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCapater);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddQuetionPanel";
            this.Tag = "1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCapater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDifficultyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQueStyle;
        private System.Windows.Forms.Panel plAddQuestion;
    }
}
﻿namespace OES.UControl
{
    partial class ChoiceEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.procon = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Dtxt = new System.Windows.Forms.RichTextBox();
            this.Ctxt = new System.Windows.Forms.RichTextBox();
            this.Btxt = new System.Windows.Forms.RichTextBox();
            this.A = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Atxt = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.procon);
            this.groupBox1.Location = new System.Drawing.Point(35, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "题干";
            // 
            // procon
            // 
            this.procon.Location = new System.Drawing.Point(7, 21);
            this.procon.Name = "procon";
            this.procon.Size = new System.Drawing.Size(501, 196);
            this.procon.TabIndex = 0;
            this.procon.Text = "";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Location = new System.Drawing.Point(33, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(104, 39);
            this.title.TabIndex = 1;
            this.title.Text = "选择题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(477, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "无";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(307, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前章节：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.Dtxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Ctxt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.A, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.C, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.B, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.D, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Atxt, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 317);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 207);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Dtxt
            // 
            this.Dtxt.Location = new System.Drawing.Point(103, 156);
            this.Dtxt.Name = "Dtxt";
            this.Dtxt.Size = new System.Drawing.Size(395, 45);
            this.Dtxt.TabIndex = 11;
            this.Dtxt.Text = "";
            // 
            // Ctxt
            // 
            this.Ctxt.Location = new System.Drawing.Point(103, 105);
            this.Ctxt.Name = "Ctxt";
            this.Ctxt.Size = new System.Drawing.Size(395, 45);
            this.Ctxt.TabIndex = 10;
            this.Ctxt.Text = "";
            // 
            // Btxt
            // 
            this.Btxt.Location = new System.Drawing.Point(103, 54);
            this.Btxt.Name = "Btxt";
            this.Btxt.Size = new System.Drawing.Size(395, 45);
            this.Btxt.TabIndex = 9;
            this.Btxt.Text = "";
            // 
            // A
            // 
            this.A.BackgroundImage = global::OES.Properties.Resources.circle_red;
            this.A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A.Location = new System.Drawing.Point(3, 3);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(44, 45);
            this.A.TabIndex = 0;
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(3, 105);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(44, 45);
            this.C.TabIndex = 2;
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(3, 54);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(44, 45);
            this.B.TabIndex = 1;
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(3, 156);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(44, 45);
            this.D.TabIndex = 3;
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 39);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "D";
            // 
            // Atxt
            // 
            this.Atxt.Location = new System.Drawing.Point(103, 3);
            this.Atxt.Name = "Atxt";
            this.Atxt.Size = new System.Drawing.Size(395, 45);
            this.Atxt.TabIndex = 8;
            this.Atxt.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(312, 566);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "保存";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(436, 566);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "取消";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ChoiceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChoiceEdit";
            this.Size = new System.Drawing.Size(593, 666);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox procon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Dtxt;
        private System.Windows.Forms.RichTextBox Ctxt;
        private System.Windows.Forms.RichTextBox Btxt;
        private System.Windows.Forms.RichTextBox Atxt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

﻿namespace OES
{
    partial class frmAddRule
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
            this.cboChapterList = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cboPType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nupdPLevel = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.nupdScore = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.nupdCount = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cboChapterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPType)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChapterList
            // 
            this.cboChapterList.DropDownWidth = 121;
            this.cboChapterList.Location = new System.Drawing.Point(71, 9);
            this.cboChapterList.Name = "cboChapterList";
            this.cboChapterList.Size = new System.Drawing.Size(121, 26);
            this.cboChapterList.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboChapterList.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboChapterList.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "章节:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(248, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(86, 23);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "题目类型:";
            // 
            // cboPType
            // 
            this.cboPType.DropDownWidth = 121;
            this.cboPType.Location = new System.Drawing.Point(340, 9);
            this.cboPType.Name = "cboPType";
            this.cboPType.Size = new System.Drawing.Size(121, 26);
            this.cboPType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPType.TabIndex = 3;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 56);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(70, 23);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel3.TabIndex = 4;
            this.kryptonLabel3.Values.Text = "难度值:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(179, 56);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(53, 23);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel4.TabIndex = 5;
            this.kryptonLabel4.Values.Text = "分值:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(340, 56);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(53, 23);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kryptonLabel5.TabIndex = 6;
            this.kryptonLabel5.Values.Text = "数量:";
            // 
            // nupdPLevel
            // 
            this.nupdPLevel.Location = new System.Drawing.Point(88, 54);
            this.nupdPLevel.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdPLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdPLevel.Name = "nupdPLevel";
            this.nupdPLevel.Size = new System.Drawing.Size(50, 25);
            this.nupdPLevel.StateCommon.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nupdPLevel.TabIndex = 7;
            this.nupdPLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupdScore
            // 
            this.nupdScore.Location = new System.Drawing.Point(248, 54);
            this.nupdScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdScore.Name = "nupdScore";
            this.nupdScore.Size = new System.Drawing.Size(50, 25);
            this.nupdScore.StateCommon.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nupdScore.TabIndex = 8;
            this.nupdScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupdCount
            // 
            this.nupdCount.Location = new System.Drawing.Point(411, 54);
            this.nupdCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupdCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdCount.Name = "nupdCount";
            this.nupdCount.Size = new System.Drawing.Size(50, 25);
            this.nupdCount.StateCommon.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nupdCount.TabIndex = 9;
            this.nupdCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(75, 107);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(109, 35);
            this.btnOK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOK.StateCommon.Border.Rounding = 16;
            this.btnOK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.TabIndex = 10;
            this.btnOK.Values.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 107);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 35);
            this.btnCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCancel.StateCommon.Border.Rounding = 16;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Values.Text = "Cancel";
            // 
            // frmAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 157);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nupdCount);
            this.Controls.Add(this.nupdScore);
            this.Controls.Add(this.nupdPLevel);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.cboPType);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cboChapterList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddRule";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加组卷规则";
            ((System.ComponentModel.ISupportInitialize)(this.cboChapterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboChapterList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboPType;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nupdPLevel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nupdScore;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nupdCount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
    }
}
﻿namespace OES.UPanel
{
    partial class PaperListPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.year = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.paperName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.startTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.endTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnFind = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaperListDGV = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.cbtnFindByYear = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.cbtnFindByTime = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.cbtnFindByName = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnSelect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.csFind = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaperListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csFind)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbtnFindByYear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbtnFindByTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbtnFindByName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSelect, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 666);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 6);
            this.flowLayoutPanel1.Controls.Add(this.year);
            this.flowLayoutPanel1.Controls.Add(this.paperName);
            this.flowLayoutPanel1.Controls.Add(this.startTime);
            this.flowLayoutPanel1.Controls.Add(this.endTime);
            this.flowLayoutPanel1.Controls.Add(this.btnFind);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(722, 35);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // year
            // 
            this.year.Dock = System.Windows.Forms.DockStyle.Left;
            this.year.Location = new System.Drawing.Point(3, 3);
            this.year.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(80, 28);
            this.year.StateCommon.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.year.TabIndex = 4;
            this.year.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // paperName
            // 
            this.paperName.Dock = System.Windows.Forms.DockStyle.Left;
            this.paperName.Location = new System.Drawing.Point(86, 0);
            this.paperName.Margin = new System.Windows.Forms.Padding(0);
            this.paperName.Name = "paperName";
            this.paperName.Size = new System.Drawing.Size(250, 26);
            this.paperName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.paperName.StateCommon.Border.Rounding = 12;
            this.paperName.StateCommon.Content.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.paperName.TabIndex = 5;
            // 
            // startTime
            // 
            this.startTime.CalendarTodayDate = new System.DateTime(2011, 3, 19, 0, 0, 0, 0);
            this.startTime.CustomFormat = "yyyy/MM/dd";
            this.startTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTime.Location = new System.Drawing.Point(339, 3);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(134, 28);
            this.startTime.StateCommon.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTime.TabIndex = 6;
            this.startTime.UseWaitCursor = true;
            this.startTime.ValueNullable = new System.DateTime(2011, 3, 27, 0, 0, 0, 0);
            // 
            // endTime
            // 
            this.endTime.CalendarTodayDate = new System.DateTime(2011, 3, 19, 0, 0, 0, 0);
            this.endTime.CustomFormat = "yyyy/MM/dd";
            this.endTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endTime.Location = new System.Drawing.Point(479, 3);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(134, 28);
            this.endTime.StateCommon.Content.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.endTime.TabIndex = 7;
            this.endTime.ValueNullable = new System.DateTime(2011, 3, 27, 0, 0, 0, 0);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(618, 2);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(99, 30);
            this.btnFind.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFind.StateCommon.Border.Rounding = 14;
            this.btnFind.StateCommon.Border.Width = 1;
            this.btnFind.TabIndex = 8;
            this.btnFind.Values.Text = "查询";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 6);
            this.groupBox1.Controls.Add(this.PaperListDGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 575);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "试卷列表";
            // 
            // PaperListDGV
            // 
            this.PaperListDGV.AllowUserToAddRows = false;
            this.PaperListDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(242)))));
            this.PaperListDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PaperListDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaperListDGV.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.PaperListDGV.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorMini;
            this.PaperListDGV.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.PaperListDGV.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.PaperListDGV.Location = new System.Drawing.Point(3, 22);
            this.PaperListDGV.Name = "PaperListDGV";
            this.PaperListDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.PaperListDGV.ReadOnly = true;
            this.PaperListDGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PaperListDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PaperListDGV.RowTemplate.Height = 23;
            this.PaperListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaperListDGV.Size = new System.Drawing.Size(710, 550);
            this.PaperListDGV.TabIndex = 0;
            this.PaperListDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaperListDGV_CellClick);
            // 
            // cbtnFindByYear
            // 
            this.cbtnFindByYear.Checked = true;
            this.cbtnFindByYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbtnFindByYear.Location = new System.Drawing.Point(13, 13);
            this.cbtnFindByYear.Name = "cbtnFindByYear";
            this.cbtnFindByYear.Size = new System.Drawing.Size(69, 24);
            this.cbtnFindByYear.TabIndex = 6;
            this.cbtnFindByYear.Values.Text = "按年";
            this.cbtnFindByYear.Click += new System.EventHandler(this.cbtnFindByYear_Click);
            // 
            // cbtnFindByTime
            // 
            this.cbtnFindByTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbtnFindByTime.Location = new System.Drawing.Point(88, 13);
            this.cbtnFindByTime.Name = "cbtnFindByTime";
            this.cbtnFindByTime.Size = new System.Drawing.Size(69, 24);
            this.cbtnFindByTime.TabIndex = 7;
            this.cbtnFindByTime.Values.Text = "按时间段";
            this.cbtnFindByTime.Click += new System.EventHandler(this.cbtnFindByTime_Click);
            // 
            // cbtnFindByName
            // 
            this.cbtnFindByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbtnFindByName.Location = new System.Drawing.Point(163, 13);
            this.cbtnFindByName.Name = "cbtnFindByName";
            this.cbtnFindByName.Size = new System.Drawing.Size(69, 24);
            this.cbtnFindByName.TabIndex = 8;
            this.cbtnFindByName.Values.Text = "按试卷名";
            this.cbtnFindByName.Click += new System.EventHandler(this.cbtnFindByName_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.Location = new System.Drawing.Point(633, 11);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(98, 28);
            this.btnSelect.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSelect.StateCommon.Border.Rounding = 12;
            this.btnSelect.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSelect.StateNormal.Border.Rounding = 12;
            this.btnSelect.TabIndex = 11;
            this.btnSelect.Values.Text = "选择试卷";
            // 
            // csFind
            // 
            this.csFind.CheckButtons.Add(this.cbtnFindByTime);
            this.csFind.CheckButtons.Add(this.cbtnFindByName);
            this.csFind.CheckButtons.Add(this.cbtnFindByYear);
            this.csFind.CheckedButton = this.cbtnFindByYear;
            // 
            // PaperListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PaperListPanel";
            this.Size = new System.Drawing.Size(742, 666);
            this.Load += new System.EventHandler(this.PaperListPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaperListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csFind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet csFind;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbtnFindByTime;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbtnFindByName;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView PaperListDGV;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton cbtnFindByYear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown year;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox paperName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker startTime;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker endTime;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFind;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSelect;
    }
}

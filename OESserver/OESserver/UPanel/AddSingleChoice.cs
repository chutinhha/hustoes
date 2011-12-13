﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OES.UPanel;

namespace OES
{
    public partial class AddSingleChoice : UserPanel 
    {
        public AddSingleChoice()
        {
            InitializeComponent();
        }
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            String capter = (this.Parent as AddQuetionPanel).Capter;
            String diffcuty = (this.Parent as AddQuetionPanel).Diffucity;
            String teststyle = (this.Parent as AddQuetionPanel).Teststyle;
            if (Content.Text == "" || Option_A.Text == "" || Option_B.Text == "" || Option_C.Text == "" || Answer_Of_Choice.Text == "" || Option_D.Text == ""||capter==""||diffcuty==""||teststyle=="")
            {
                MessageBox.Show("请完成试题信息");
            }
            
            
            else if (MessageBox.Show("确定提交吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定返回么？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
 
            }

        }
        public void Reset()
        {
            Content.Text = "";
            Option_A.Text = "";
            Option_B.Text = "";
            Option_C.Text = "";
            Option_D.Text = "";
            Answer_Of_Choice.Text = "";
        }
       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OES.UControl
{
    public partial class StudentAdd : UserControl
    {

        string permissionUserName = "";                 //当前登录的用户名，用来区分权限，若为空表示是管理员

        public StudentAdd()
        {
            InitializeComponent();
            radioAddOne.Checked = true;
            groupAddMany.Enabled = false;
            if (InfoControl.User.permission == 0)
            {
                permissionUserName = InfoControl.User.UserName;
                ChangeDisplay();
            }
            DisableDept();
            showAllDepts();
        }
        
        private void DisableDept()  //暂时把批量导入的班级部分给隐藏掉
        {
            textClass.Visible = false;
            textDept.Visible = false;
            comboManyClass.Visible = false;
            comboManyDept.Visible = false;
            label1.Visible = label8.Visible = false;
        }

        private void ChangeDisplay()
        {
            textClass.Hide();
            textDept.Hide();
            comboManyDept.Show();
            comboManyClass.Show();
        }

        private void radioAddOne_CheckedChanged(object sender, EventArgs e)
        {
            groupAddOne.Enabled = radioAddOne.Checked;
        }

        private void radioAddMany_CheckedChanged(object sender, EventArgs e)
        {
            groupAddMany.Enabled = radioAddMany.Checked;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void showAllDepts()
        {
            List<string> dps = new List<string>();
            if (permissionUserName == "")
                dps = InfoControl.OesData.FindAllDept();
            else
                dps = InfoControl.OesData.FindAllDeptWithTeacher(permissionUserName);
            object[] ob = new object[dps.Count];
            for (int i = 0; i < dps.Count; i++)
                ob[i] = dps[i];

            comboOneDept.Items.Clear();
            comboOneDept.Items.AddRange(ob);
            comboOneDept.SelectedIndex = 0;

            comboManyDept.Items.Clear();
            comboManyDept.Items.AddRange(ob);
            comboManyDept.SelectedIndex = 0;
        }

        private void showClassInDept(string dept, ComboBox com)
        {
            List<String> cls = new List<string>();
            if (permissionUserName == "")
                cls = InfoControl.OesData.FindClassNameOfDept(dept);
            else
                cls = InfoControl.OesData.FindClassNameOfDeptWithTeacher(dept, permissionUserName);
            object[] ob = new object[cls.Count];
            for (int i = 0; i < cls.Count; i++)
                ob[i] = cls[i];
            com.Items.Clear();
            com.Items.AddRange(ob);
            com.SelectedIndex = 0;
        }

        private void comboOneDept_TextChanged(object sender, EventArgs e)
        {
            showClassInDept(comboOneDept.Text, comboOneClass);
        }


        private void comboManyDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            showClassInDept(comboManyDept.Text, comboManyClass);
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textID.Text == "")
            {
                MessageBox.Show("输入信息不完整！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textPW.Text != "" && textPW.Text != textPW2.Text)
            {
                MessageBox.Show("两次密码输入不一致！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string pw = textPW.Text != "" ? textPW.Text : textID.Text;
            try
            {
                InfoControl.OesData.AddStudent(textID.Text, textName.Text, comboOneDept.Text, comboOneClass.Text, pw);
                MessageBox.Show("添加成功！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInfo();
            }
            catch
            {
                MessageBox.Show("添加失败，请检查学号是否重复！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearInfo()
        {
            showAllDepts();
            textID.Text = textName.Text = textPW.Text = textPW2.Text = 
                textFile.Text = textDept.Text = textClass.Text = "";
        }

        private void btnAddMany_Click(object sender, EventArgs e)
        {
            List<string[]> dataList;
            //bool infoState = true;
            //if (textFile.Text == "")
            //    infoState = false;
            //else if ((textDept.Text == "" || textClass.Text == "") && textDept.Visible == true)
            //    infoState = false;
            //if (!infoState)
            //{
            //    MessageBox.Show("输入信息不完整！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            try 
            {
                dataList = CSVHelper.CSVImporter.getObjectInCSV(textFile.Text, 4);
            } 
            catch 
            {
                MessageBox.Show("文件读取失败！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                //string dept, className;
                //if (textDept.Visible == true)
                //{
                //    dept = textDept.Text;
                //    className = textClass.Text;
                //}
                //else
                //{
                //    dept = comboManyDept.Text; 
                //    className = comboManyClass.Text;
                //}
                //InfoControl.OesData.AddManyStudents(dept, className, dataList);
                InfoControl.OesData.ImportStudent(dataList);
                MessageBox.Show("学生导入成功！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearInfo();
            }
            catch
            {
                MessageBox.Show("导入失败！", "学生管理", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "CSV文件(逗号分隔)(*.csv)|*.csv";
            of.ShowDialog();
            textFile.Text = of.FileName;
        }

    }
}

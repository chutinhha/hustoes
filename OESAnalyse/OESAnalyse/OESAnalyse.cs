﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Collections;
using OES.Model;
using OES;

namespace OESAnalyse
{
    public partial class OESAnalyse : Form
    {
        private FolderBrowserDialog fbd=new FolderBrowserDialog();
        private String path;
        private DirectoryInfo[] theFiles; 
        private DirectoryInfo firstFile;
        private List<FileInfo> results=new List<FileInfo>();
        private List<Student> students = new List<Student>();
        private List<string> stuIds = new List<string>();
        private Boolean classFirst = true;

        ScoreAnalyse sco = new ScoreAnalyse();

        List<Student>myList=new List<Student>();
        DataTable myTable = new DataTable("null");

        private static OESData oesData = new OESData();
        public static OESData OesData
        {
            get
            {
                if (oesData == null) { oesData = new OESData(); }
                return OESAnalyse.oesData;
            }
            set { OESAnalyse.oesData = value; }
        }

        public OESAnalyse()
        {
            InitializeComponent();
        }

        private void PathBut_Click(object sender, EventArgs e)
        {
            List<string> className = new List<string>();
            List<string> examId = new List<string>();
            string stuId, paperId;

            if (fbd.ShowDialog().Equals(DialogResult.OK))
            {
                path = fbd.SelectedPath;
                firstFile = new DirectoryInfo(path);

                theFiles = firstFile.GetDirectories();
                if (theFiles != null)
                {
                    
                    for (int i = 0; i < theFiles.Length; i++)
                        if (theFiles[i].GetFiles("Result.xml").Length>0)
                            results.Add(theFiles[i].GetFiles("Result.xml")[0]);
                    for(int i=0;i<results.Count;i++)
                    {
                        sco.getSAndPId(results[i].FullName,out stuId,out paperId);
                        stuIds.Add(stuId);
                        students.Add(oesData.FindStudentByStudentId(stuIds[i])[0]);
                        students[i].examID = paperId;
                        students[i].password = Convert.ToString(sco.getScore(results[i].FullName));
                        while (!className.Contains(students[i].className))
                        {
                            className.Add(students[i].className);
                            this.ClassCombo.Items.Add(students[i].className);
                        }
                        while (!examId.Contains(students[i].examID))
                        {
                            examId.Add(students[i].examID);
                            this.PaperCombo.Items.Add(students[i].examID);
                        }
                    }
                }
            }       
        }

        private void OrderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderCombo.SelectedIndex == 0)   
            {
                ClassCombo.Enabled = true;
                PaperCombo.Enabled = false;
                classFirst = true;
            }
            else if (OrderCombo.SelectedIndex == 1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                PaperCombo.Enabled = true;
                ClassCombo.Enabled = false;
                classFirst = false;
            } 
        }


        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> papers = new List<string>();
            if (this.PaperCombo.Enabled == true && this.ClassCombo.Enabled == true)
            {
                //传List<Student>
                printOut(findStuByCAP(Convert.ToString(this.ClassCombo.SelectedItem), Convert.ToString(this.PaperCombo.SelectedItem)));
            }
            if (classFirst)
            {
                this.PaperCombo.Items.Clear();
                papers = findPIdByClassId(Convert.ToString(this.ClassCombo.SelectedItem));
                for (int i = 0; i < papers.Count; i++)
                {
                    this.PaperCombo.Items.Add(papers[i]);
                }
                this.PaperCombo.Enabled = true;
            }
            
        }


        //根据班级寻找当前目录下该班级所考试卷id
        public List<string> findPIdByClassId(string className)
        {
            List<string> paperIds = new List<string>();
            for (int i = 0; i < students.Count; i++)
            {
                while (students[i].className == className && !paperIds.Contains(students[i].examID))
                {
                    paperIds.Add(students[i].examID);
                }
            }
            return paperIds;
        }


        public  void printOut(List<Student> myList)
        {
            this.dataGridView1.DataSource = null;
            DataTable myTable = new DataTable("paper");
            myTable.Columns.Add("学号");
            myTable.Columns.Add("姓名");
            myTable.Columns.Add("班级");
            myTable.Columns.Add("试卷名称");
            myTable.Columns.Add("成绩");
            for (int i = 0; i <= myList.Count; i++)
            {
                myTable.Rows[i][0] = myList[i].ID;
                myTable.Rows[i][1] = myList[i].sName;
                myTable.Rows[i][1] = myList[i].className;
                myTable.Rows[i][2] = myList[i].examID;
                myTable.Rows[i][3] = myList[i].password;
            }
            this.dataGridView1.DataSource = myTable.DefaultView;
        }

        //根据试卷寻找当前目录下班级
        public List<string> findCNByPaperId(string paperId)
        {
            List<string> classNames = new List<string>();
            for (int i = 0; i < students.Count; i++)
            {
                while (students[i].examID == paperId && !classNames.Contains(students[i].className))
                {
                    classNames.Add(students[i].className);
                }
            }
            return classNames;
        }
        //根据试卷id和班级寻找学生
        public List<Student> findStuByCAP(string className, string paperId)
        {
            List<Student> stus = new List<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].className == className && students[i].examID == paperId)
                {
                    stus.Add(students[i]);
                }
            }
            return stus;
        }

        private void PaperCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<string> classes = new List<string>();
            if (this.PaperCombo.Enabled == true && this.ClassCombo.Enabled == true)
            {
                //传List<Student>
                printOut(findStuByCAP(Convert.ToString(this.ClassCombo.SelectedItem), Convert.ToString(this.PaperCombo.SelectedItem)));
            }
            if (!classFirst)
            {
                this.ClassCombo.Items.Clear();
                classes = findCNByPaperId(Convert.ToString(this.PaperCombo.SelectedItem));
                for (int i = 0; i < classes.Count; i++)
                {
                    this.ClassCombo.Items.Add(classes[i]);
                }
                this.ClassCombo.Enabled = true;
            }
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using OES.Model;
using OES.Net;


namespace OES.UPanel
{
    public partial class ProModify : UserPanel
    {
        public ProgramProblem newProblem;
        public DataTable dtAnsList;
        public DataView dvAnsList;
        public int BlankCount;
        public int AnsCount;

        private int PID;
        private PLanguage language;
        private ProgramPType ProType = ProgramPType.Modify;
        private bool addnew;

        private frmAddAnswer newans;

        public ProModify()
        {
            InitializeComponent();
        }

        public override void ReLoad()
        {
            CleanData();
            addnew = true;
            this.Visible = true;
        }

        private void CleanData()
        {
            rtbPContent.Text = "";
            tbProblemFile.Text = "";
            BlankCount = 0;
            AnsCount = 0;
            newProblem = new ProgramProblem();
            dtAnsList = new DataTable();
            dtAnsList.Columns.Add("SeqNum", typeof(int));
            dtAnsList.Columns.Add("Value", typeof(string));
            dvAnsList = new DataView(dtAnsList);
            dvAnsList.Sort = "SeqNum";
            lbAnsList.DataSource = dvAnsList;
            lbAnsList.DisplayMember = "Value";
        }

        public override void ReLoad(int pid)
        {
            CleanData();
            addnew = false;            
            PID = pid;
            //(this.Parent.Parent as AddQuetionPanel).QueStyle = 
            newProblem = InfoControl.getProProblem(pid);

            rtbPContent.Text = newProblem.problem;
            foreach (ProgramAnswer ans in newProblem.ansList)
            {
                object[] values = new object[2];
                values[0] = ans.SeqNum;
                values[1] = ans.SeqNum.ToString() + ": " + ans.Output;
                dtAnsList.Rows.Add(values);
            }
            switch (newProblem.language)
            {
                case PLanguage.C:
                    InfoControl.ClientObj.LoadCCompletion(pid, Convert.ToInt32(InfoControl.User.Id));
                    tbProblemFile.Text = InfoControl.config["CompletionPath"] + "p" + pid.ToString() + ".c";
                    break;
                case PLanguage.CPP:
                    InfoControl.ClientObj.LoadCppCompletion(pid, Convert.ToInt32(InfoControl.User.Id));
                    tbProblemFile.Text = InfoControl.config["CompletionPath"] + "p" + pid.ToString() + ".cpp";
                    break;
                case PLanguage.VB:
                    InfoControl.ClientObj.LoadVbCompletion(pid, Convert.ToInt32(InfoControl.User.Id));
                    tbProblemFile.Text = InfoControl.config["CompletionPath"] + "p" + pid.ToString() + ".vb";
                    break;
            }
            InfoControl.ClientObj.ReceiveFiles();
        }


        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (ofdBrowser.ShowDialog() == DialogResult.OK)
            {
                tbProblemFile.Text = ofdBrowser.FileName;
                BlankCount = InfoControl.coutnAnswer(tbProblemFile.Text);
                switch (Path.GetExtension(ofdBrowser.FileName).ToLower())
                {
                    case ".c":
                        language = PLanguage.C;
                        break;
                    case ".cpp":
                        language = PLanguage.CPP;
                        break;
                    case ".vb":
                        language = PLanguage.VB;
                        break;
                    default:
                        language = PLanguage.Null;
                        break;
                }

            }
        }

        private void btnAddAns_Click(object sender, EventArgs e)
        {

            if (File.Exists(tbProblemFile.Text))
            {
                if (BlankCount > 0)
                {
                    newans = new frmAddAnswer(BlankCount);
                    newans.ShowDialog();
                    if (newans.Result)
                    {
                        newProblem.ansList.Add(newans.ProAns);
                        object[] values = new object[2];
                        values[0] = newans.ProAns.SeqNum;
                        values[1] = newans.ProAns.SeqNum.ToString() + ": " + newans.ProAns.Output;
                        dtAnsList.Rows.Add(values);
                    }
                }
                else
                {
                    MessageBox.Show("文件格式不正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbAnsList.SelectedIndex >= 0)
            {
                if (MessageBox.Show("确定删除记录", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DataRow dr = dvAnsList[lbAnsList.SelectedIndex].Row;
                    newProblem.ansList.Remove(newProblem.ansList[dtAnsList.Rows.IndexOf(dr)]);
                    dtAnsList.Rows.Remove(dr);
                }
            }
            else
            {
                MessageBox.Show("未选择答案", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbAnsList.SelectedIndex >= 0)
            {
                DataRow dr = dvAnsList[lbAnsList.SelectedIndex].Row;
                newans = new frmAddAnswer(BlankCount, newProblem.ansList[dtAnsList.Rows.IndexOf(dr)]);
                newans.ShowDialog();
                if (newans.Result)
                {
                    newProblem.ansList[dtAnsList.Rows.IndexOf(dr)] = newans.ProAns;
                    dr[0] = newans.ProAns.SeqNum;
                    dr[1] = newans.ProAns.SeqNum.ToString() + ": " + newans.ProAns.Output;
                }
            }
            else
            {
                MessageBox.Show("未选择答案", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tbProblemFile.Text))
            {
                MessageBox.Show("文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int Unit = (this.Parent.Parent as AddQuetionPanel).Capter;
            int PLevel = (this.Parent.Parent as AddQuetionPanel).Difficulity;
            if (addnew)
            {
                PID = InfoControl.OesData.AddProgram(rtbPContent.Text, ProType, language, Unit, PLevel);
            }
            else
            {
                InfoControl.OesData.DeleteProgramAnswer(PID);
                InfoControl.OesData.UpdateProgram(PID, ProgramPType.Modify, language, Unit, PLevel);
            }
            if (PID > 0)
            {
                foreach (ProgramAnswer ans in newProblem.ansList)
                {
                    InfoControl.OesData.AddProgramAnswer(PID, ans.SeqNum, ans.Input, ans.Output);
                }
                switch (language)
                {
                    case PLanguage.C:
                        if (tbProblemFile.Text != InfoControl.config["ModificationPath"] + "p" + PID.ToString() + ".c")
                        {
                            File.Copy(tbProblemFile.Text, InfoControl.config["ModificationPath"] + "p" + PID.ToString() + ".c", true);
                        }
                        InfoControl.ClientObj.SaveCModification(PID, Convert.ToInt32(InfoControl.User.Id));
                        break;
                    case PLanguage.CPP:
                        if (tbProblemFile.Text != InfoControl.config["ModificationPath"] + "p" + PID.ToString() + ".cpp")
                        {
                            File.Copy(tbProblemFile.Text, InfoControl.config["ModificationPath"] + "p" + PID.ToString() + ".cpp", true);
                        }
                        InfoControl.ClientObj.SaveCppModification(PID, Convert.ToInt32(InfoControl.User.Id));
                        break;
                    case PLanguage.VB:
                        if (tbProblemFile.Text != InfoControl.config["ModificationPath"] + "p" + PID.ToString() + ".vb")
                        {
                            File.Copy(tbProblemFile.Text, InfoControl.config["ModificationPath"] + "p" + PID.ToString() + ".vb", true);
                        }
                        InfoControl.ClientObj.SaveVbModification(PID, Convert.ToInt32(InfoControl.User.Id));
                        break;
                }
                InfoControl.ClientObj.SendFiles();
                ClientEvt.FilesComplete += new Action(ClientEvt_FilesComplete);
                
            }

        }

        void ClientEvt_FilesComplete()
        {
            MessageBox.Show("题目添加成功！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClientEvt.FilesComplete -= ClientEvt_FilesComplete;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定返回么？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PanelControl.ChangPanel(0);
            }
        }
    }
}

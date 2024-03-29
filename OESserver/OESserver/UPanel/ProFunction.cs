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
    public partial class ProFunction : UserPanel
    {
        private DataTable dtAnsList;
        public ProgramProblem newProblem;
        private List<ProgramAnswer> AnsList;
        private frmAddProData frmaddProData;
        private PLanguage language;
        private bool addnew;
        private int PID;

        public ProFunction()
        {
            InitializeComponent();
            dtAnsList = new DataTable();
            dtAnsList.Columns.Add("输入");
            dtAnsList.Columns.Add("输出");

            dgvAnsList.DataSource = dtAnsList;
            dgvAnsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnsList.Columns[0].FillWeight = 50;
            dgvAnsList.Columns[1].FillWeight = 50;
            dgvAnsList.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvAnsList.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void CleanData()
        {
            tbAnswerFile.Text = "";
            tbProblemFile.Text = "";
            rtbPContent.Text = "";
            AnsList = new List<ProgramAnswer>();
            dtAnsList.Clear();
        }


        public override void ReLoad()
        {
            CleanData();
            addnew = true;
            this.Visible = true;
        }
        public override void ReLoad(int pid)
        {
            CleanData();
            addnew = false;
            PID = pid;
            newProblem = InfoControl.getProProblem(pid);
            rtbPContent.Text = newProblem.problem;
            AnsList = newProblem.ansList;
            foreach (ProgramAnswer ans in newProblem.ansList)
            {
                dtAnsList.Rows.Add(new object[2] { ans.Input, ans.Output });
            }
            switch (newProblem.language)
            {
                case PLanguage.C:
                    InfoControl.ClientObj.LoadCFunctionA(pid, Convert.ToInt32(InfoControl.User.Id));
                    InfoControl.ClientObj.LoadCFunctionP(pid, Convert.ToInt32(InfoControl.User.Id));
                    tbProblemFile.Text = InfoControl.config["FunctionPath"] + "p" + pid.ToString() + ".c";
                    tbAnswerFile.Text = InfoControl.config["FunctionPath"] + "a" + pid.ToString() + ".c";
                    break;
                case PLanguage.CPP:
                    InfoControl.ClientObj.LoadCppFunctionA(pid, Convert.ToInt32(InfoControl.User.Id));
                    InfoControl.ClientObj.LoadCppFunctionP(pid, Convert.ToInt32(InfoControl.User.Id));
                    tbProblemFile.Text = InfoControl.config["FunctionPath"] + "p" + pid.ToString() + ".cpp";
                    tbAnswerFile.Text = InfoControl.config["FunctionPath"] + "a" + pid.ToString() + ".cpp";
                    break;
                case PLanguage.VB:
                    InfoControl.ClientObj.LoadVbFunctionA(pid, Convert.ToInt32(InfoControl.User.Id));
                    InfoControl.ClientObj.LoadVbFunctionP(pid, Convert.ToInt32(InfoControl.User.Id));
                    tbProblemFile.Text = InfoControl.config["FunctionPath"] + "p" + pid.ToString() + ".vb";
                    tbAnswerFile.Text = InfoControl.config["FunctionPath"] + "a" + pid.ToString() + ".vb";
                    break;
            }
            InfoControl.ClientObj.ReceiveFiles();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int Unit = (this.Parent.Parent as AddQuetionPanel).Capter;
            int PLevel = (this.Parent.Parent as AddQuetionPanel).Difficulity;            
            if ((!File.Exists(tbAnswerFile.Text)) || (!File.Exists(tbProblemFile.Text)))
            {
                MessageBox.Show("文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SetLanguage();
            if (addnew)
            {
                PID = InfoControl.OesData.AddProgram(rtbPContent.Text, ProgramPType.Function, language, Unit, PLevel);
            }
            else
            {
                InfoControl.OesData.DeleteProgramAnswer(PID);
                InfoControl.OesData.UpdateProgram(PID, ProgramPType.Function, language, Unit, PLevel);
            }
            if (PID > 0)
            {
                foreach (ProgramAnswer ans in AnsList)
                {
                    InfoControl.OesData.AddProgramAnswer(PID, ans.SeqNum, ans.Input, ans.Output);
                }
                switch (language)
                {
                    case PLanguage.C:
                        if (tbProblemFile.Text != InfoControl.config["FunctionPath"] + "p" + PID.ToString() + ".c")
                        {
                            File.Copy(tbProblemFile.Text, InfoControl.config["FunctionPath"] + "p" + PID.ToString() + ".c", true);
                        }
                        if (tbAnswerFile.Text != InfoControl.config["FunctionPath"] + "a" + PID.ToString() + ".c")
                        {
                            File.Copy(tbAnswerFile.Text, InfoControl.config["FunctionPath"] + "a" + PID.ToString() + ".c", true);
                        }
                        InfoControl.ClientObj.SaveCFunctionA(PID, Convert.ToInt32(InfoControl.User.Id));
                        InfoControl.ClientObj.SaveCFunctionP(PID, Convert.ToInt32(InfoControl.User.Id));
                        break;
                    case PLanguage.CPP:
                        if(tbProblemFile.Text!=InfoControl.config["FunctionPath"] + "p" + PID.ToString() + ".cpp")
                        {
                            File.Copy(tbProblemFile.Text, InfoControl.config["FunctionPath"] + "p" + PID.ToString() + ".cpp", true);
                        }
                        if (tbAnswerFile.Text != InfoControl.config["FunctionPath"] + "a" + PID.ToString() + ".cpp")
                        {
                            File.Copy(tbAnswerFile.Text, InfoControl.config["FunctionPath"] + "a" + PID.ToString() + ".cpp", true);
                        }                        
                        InfoControl.ClientObj.SaveCppFunctionA(PID, Convert.ToInt32(InfoControl.User.Id));
                        InfoControl.ClientObj.SaveCppFunctionP(PID, Convert.ToInt32(InfoControl.User.Id));
                        break;
                    case PLanguage.VB:
                        if (tbProblemFile.Text != InfoControl.config["FunctionPath"] + "p" + PID.ToString() + ".vb")
                        {
                            File.Copy(tbProblemFile.Text, InfoControl.config["FunctionPath"] + "p" + PID.ToString() + ".vb", true);
                        }
                        if (tbAnswerFile.Text != InfoControl.config["FunctionPath"] + "a" + PID.ToString() + ".vb")
                        {
                            File.Copy(tbAnswerFile.Text, InfoControl.config["FunctionPath"] + "a" + PID.ToString() + ".vb", true);
                        }
                        InfoControl.ClientObj.SaveVbFunctionP(PID, Convert.ToInt32(InfoControl.User.Id));
                        InfoControl.ClientObj.SaveVbFunctionA(PID, Convert.ToInt32(InfoControl.User.Id));
                        break;
                }
                ClientEvt.FilesComplete += new Action(ClientEvt_FilesComplete);
                InfoControl.ClientObj.SendFiles();
            }
        }

        void ClientEvt_FilesComplete()
        {
            MessageBox.Show("题目添加成功！", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClientEvt.FilesComplete -= ClientEvt_FilesComplete;
            CleanData();
        }

        private void btnBrowserSource_Click(object sender, EventArgs e)
        {
            if (ofdBrowser.ShowDialog() == DialogResult.OK)
            {
                tbProblemFile.Text = ofdBrowser.FileName;
            }
        }

        private void SetLanguage()
        {
            switch (Path.GetExtension(tbProblemFile.Text).ToLower())
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

        private void btnBrowserAns_Click(object sender, EventArgs e)
        {
            if (ofdBrowser.ShowDialog() == DialogResult.OK)
            {
                tbAnswerFile.Text = ofdBrowser.FileName;
            }
        }

        private void btnAddAns_Click(object sender, EventArgs e)
        {
            if (File.Exists(tbAnswerFile.Text))
            {
                frmaddProData = new frmAddProData(tbAnswerFile.Text);
                frmaddProData.ShowDialog();
                if (frmaddProData.Result == true)
                {
                    AnsList.Add(frmaddProData.ProAns);
                    dtAnsList.Rows.Add(new object[2] { frmaddProData.ProAns.Input, frmaddProData.ProAns.Output });
                }
            }
            else
            {
                MessageBox.Show("文件不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAnsList.CurrentRow != null && dgvAnsList.CurrentRow.Index >= 0)
            {
                frmaddProData = new frmAddProData(tbAnswerFile.Text, AnsList[dgvAnsList.CurrentRow.Index]);
                frmaddProData.ShowDialog();
                if (frmaddProData.Result == true)
                {
                    dtAnsList.Rows[dgvAnsList.CurrentRow.Index][0] = frmaddProData.ProAns.Input;
                    dtAnsList.Rows[dgvAnsList.CurrentRow.Index][1] = frmaddProData.ProAns.Output;
                    AnsList[dgvAnsList.CurrentRow.Index] = frmaddProData.ProAns;
                }
            }
            else
            {
                MessageBox.Show("未选择答案", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvAnsList.CurrentRow != null && dgvAnsList.CurrentRow.Index >= 0)
            {

                if (MessageBox.Show("确定删除记录", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    AnsList.Remove(AnsList[dgvAnsList.CurrentRow.Index]);
                    dtAnsList.Rows.Remove(dtAnsList.Rows[dgvAnsList.CurrentRow.Index]);
                }

            }
            else
            {
                MessageBox.Show("未选择答案", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

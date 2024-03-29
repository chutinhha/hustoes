﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OES.Net;
using OES.Model;

namespace OES
{
    public partial class TeaPassForm : Form
    {
        public TeaPassForm()
        {
            InitializeComponent();
            ClientEvt.ConfirmReStart -= ClientEvt_ConfirmReStart;
            ClientEvt.ConfirmReStart += new EventHandler(ClientEvt_ConfirmReStart);
        }

        void ClientEvt_ConfirmReStart(object sender, EventArgs e)
        {
            ClientControl.TeaPassForm.Invoke(new MethodInvoker(() =>
            {
                ClientControl.paper.ReadPaper();

                ClientControl.isResume = false;
                if (ClientControl.ControlBar.Init())
                {
                    ClientControl.ControlBar.Show();
                    ClientControl.MainForm.Show();
                    ClientControl.TeaPassForm.Dispose();
                    ClientControl.TeaPassForm = null;
                }
                ClientControl.State = 8;        //设置考试端为开始重考状态
            }));

        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            ClientControl.ExamForm.Show();
            this.Dispose();
            ClientControl.TeaPassForm = null;
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            //验证教师密码正确性
            //
            ClientEvt.beginExam(3,maskedTextBox1.Text);
            
        }
    }
}

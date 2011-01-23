﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OESMonitor.Net;

namespace OESMonitor
{
    public partial class OESMonitor : Form
    {
        public List<Computer> ComputerList = new List<Computer>();
        CommandLine cl = new CommandLine();
       
        public OESMonitor()
        {
            InitializeComponent();
            panel1.Controls.Add( ComputerState.getInstance());
        }
       
        public void AddComputer(Client client)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                Computer com = new Computer();
                com.CreateControl();
                Computer.Add(com);
                com.State = 1;
                com.Client = client;
                ComputerList.Add(com);

                UpdateList();
            }));
        }
        private void UpdateList()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Computer c in ComputerList)
            {
                flowLayoutPanel1.Controls.Add(c);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel1.Controls.Add(new Computer());
        }

        private void OESMonitor_Load(object sender, EventArgs e)
        {
            Net.MessageSupervisor.mainForm = this;
            Net.MessageSupervisor.targetFrm = cl;
            cl.Show();
            Program.server = new Net.OESServer();
        }
    }
}
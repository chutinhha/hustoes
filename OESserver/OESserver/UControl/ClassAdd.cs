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
    public partial class ClassAdd : UserControl
    {
        public ClassAdd()
        {
            InitializeComponent();
            radioAddOne.Checked = true;
            groupAddMany.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radioAddOne_CheckedChanged(object sender, EventArgs e)
        {
            groupAddOne.Enabled = radioAddOne.Checked;
        }

        private void radioAddMany_CheckedChanged(object sender, EventArgs e)
        {
            groupAddMany.Enabled = radioAddMany.Checked;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OESMonitor.PaperControl
{
    public class PaperControl
    {
        private static OESData oesData = null;
        public static OESData OesData
        {
            get
            {
                if (oesData == null) { oesData = new OESData(); }
                return PaperControl.oesData;
            }
            set { PaperControl.oesData = value; }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OES.Model
{
    public class ProgramProblem:Problem
    {
        public Language language;
        public ProType Type;
        public List<ProgramAnswer> ansList;

        public ProgramProblem()
        {
            ansList = new List<ProgramAnswer>();
        }

        public enum ProType
        {
            Completion=0,
            Modify = 1,
            Function=2
        }
        public enum Language
        {
            C=0,
            CPP=1,
            VB=2            
        }
    }
}
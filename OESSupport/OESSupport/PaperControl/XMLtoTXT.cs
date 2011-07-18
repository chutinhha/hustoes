﻿using System;
using System.Collections.Generic;
 
using System.Text;
using System.IO;
using OES.Model;
using OESSupport.XMLFile;
using OESSupport.Configuration;

namespace OESSupport.PaperControl
{
    public class XMLtoTXT
    {
        static public List<IdScoreType> problemList=new List<IdScoreType>();
        private static string paperid;
        static public string[] prostr = new string[9];
        static private string[] fileName = { "a.txt", "b.txt", "c.txt", "d.txt", "e.txt", 
                                                    "f.txt","g.txt","h.txt","i.txt"};
        static public Choice choice=new Choice();
        static public Judge judge=new Judge();
        static public Completion completion=new Completion();
        static public OfficeExcel officeexcel=new OfficeExcel();
        static public OfficePowerPoint officeppt=new OfficePowerPoint();
        static public OfficeWord officeword=new OfficeWord();
        static public PCompletion pcompletion=new PCompletion();
        static public PModif pmodif=new PModif();
        static public PFunction pfunction=new PFunction();
        
        static public void xmltotxt(string xmlpath)
        {
            problemList = XMLControl.ReadPaper(xmlpath);
            paperid = XMLControl.getPaperId(xmlpath);
            for(int i=0;i<9;i++)
            {
                prostr[i] = "";
            }
            foreach (IdScoreType problem in problemList)
            {
                switch(problem.pt)
                {
                    case ProblemType.Choice:
                        choice = PaperControl.OesData.FindChoiceById(problem.id.ToString())[0];
                        prostr[0] = prostr[0] + choice.problem + "\r\n";
                        prostr[0] = prostr[0] + choice.optionA + "\r\n";
                        prostr[0] = prostr[0] + choice.optionB + "\r\n";
                        prostr[0] = prostr[0] + choice.optionC + "\r\n";
                        prostr[0] = prostr[0] + choice.optionD + "\r\n";                        
                        break;
                    case ProblemType.Completion:
                        completion = PaperControl.OesData.FindCompletionById(problem.id.ToString())[0];
                        prostr[1] = prostr[1] + completion.problem + "\r\n";                        
                        break;
                    case ProblemType.Tof:
                        judge = PaperControl.OesData.FindTofById(problem.id.ToString())[0];
                        prostr[2] = prostr[2] + judge.problem + "\r\n";    
                        break;
                    case ProblemType.Excel:
                        officeexcel = PaperControl.OesData.FindOfficeExcelById(problem.id.ToString())[0];
                        prostr[3] = prostr[3] + officeexcel.problem + "\r\n";    

                        break;
                    case ProblemType.PowerPoint:
                        officeppt = PaperControl.OesData.FindOfficePowerPointById(problem.id.ToString())[0];
                        prostr[4] = prostr[4] + officeppt.problem + "\r\n";    
                        break;       
                    case ProblemType.Word:
                        officeword = PaperControl.OesData.FindOfficeWordById(problem.id.ToString())[0];
                        prostr[5] = prostr[5] + officeword.problem + "\r\n"; 
                        break;
                    case ProblemType.ProgramCompletion:
                        pcompletion = PaperControl.OesData.FindCompletionProgramById(problem.id.ToString())[0];
                        prostr[6] = prostr[6] + pcompletion.problem + "\r\n";
                        break;
                    case ProblemType.ProgramModification:
                        pmodif=PaperControl.OesData.FindModificationProgramById(problem.id.ToString())[0];
                        prostr[7] = prostr[7] + pmodif.problem + "\r\n";
                        break;
                    case ProblemType.ProgramFun:
                        pfunction = PaperControl.OesData.FindFunProgramById(problem.id.ToString())[0];
                        prostr[8] = prostr[8] + pfunction.problem + "\r\n";
                        break;
                }
            }
 
            string paperpath="";
            string filepath="";
            paperpath = Config.PaperPkg + paperid+"\\";
            Directory.CreateDirectory(paperpath);
            for(int i=0;i<9;i++)
            {
                if(prostr[i]!="")
                {
                    filepath = paperpath + fileName[i];
                    //File.Create(filepath);
                    StreamWriter sw = File.CreateText(filepath);
                    sw.Write(prostr[i]);
                    sw.Close();
                }
            }
        }
    }
}
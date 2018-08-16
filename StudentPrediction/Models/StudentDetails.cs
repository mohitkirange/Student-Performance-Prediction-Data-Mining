using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentPrediction.Models
{
    public class StudentDetails
    {
        public string Name { get; set; }
        public string Quiz1 { get; set; }
        public string Quiz2 { get; set; }
        public string Quiz3 { get; set; }
        public string Mid1 { get; set; }
        public string Mid2 { get; set; }
        public string Project { get; set; }
        public string Tutorial { get; set; }
        public string FinalLab { get; set; }
        public string FinalExam { get; set; }
        //public string Total { get; set; }
        public string Grade { get; set; }
    }
}
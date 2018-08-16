using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentPrediction.Models;

namespace StudentPrediction.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Subject1()
        {
            return View();
        }

        public ActionResult Subject2()
        {
            return View();
        }

        public ActionResult Mumbaiuniv()
        {
            return View();
        }

        public ActionResult Previousdata()
        {
            return View();
        }
        public ActionResult Calculate(StudentDetails student)
        {
            if (String.IsNullOrEmpty(student.Quiz1))
            {
                student.Quiz1 = "4.145";
            }

            if (String.IsNullOrEmpty(student.Quiz2))
            {
                student.Quiz2 = "3.935";
            }

            if (String.IsNullOrEmpty(student.Quiz3))
            {
                student.Quiz3 = "3.79";
            }

            if (String.IsNullOrEmpty(student.Mid1))
            {
                student.Mid1 = "7.78";
            }

            if (String.IsNullOrEmpty(student.Mid2))
            {
                student.Mid2 = "7.59";
            }

            if (String.IsNullOrEmpty(student.Project))
            {
                student.Project = "8.62";
            }

            if (String.IsNullOrEmpty(student.Tutorial))
            {
                student.Tutorial = "4.11";
            }

            if (String.IsNullOrEmpty(student.FinalLab))
            {
                student.FinalLab = "7.46";
            }

            if (String.IsNullOrEmpty(student.FinalExam))
            {
                student.FinalExam = "34.37";
            }

            double total = 
                Convert.ToDouble(student.Quiz1) +
                Convert.ToDouble(student.Quiz2) +
                Convert.ToDouble(student.Quiz3) +
                Convert.ToDouble(student.Mid1) +
                Convert.ToDouble(student.Mid2) +
                Convert.ToDouble(student.Project) +
                Convert.ToDouble(student.Tutorial) +
                Convert.ToDouble(student.FinalExam) +
                Convert.ToDouble(student.FinalLab);
            //student.Total = total.ToString();

            if (total >= 90) 
            {
                student.Grade = "A";
            }
            else if (total >=80 && total <=89)
            {
                student.Grade = "B";
            }
            else if (total >=70 && total <=79)
            {
                student.Grade = "C";
            }
            else if (total >= 60 && total <=69)
            {
                student.Grade = "D";
            }
            else if (total >=0 && total <=59)
            {
                student.Grade = "F";
            }


            return View(student);
        }

        public ActionResult Calculate1(StudentDetails student)
        {
            if (String.IsNullOrEmpty(student.Quiz1))
            {
                student.Quiz1 = "4.1";
            }

            if (String.IsNullOrEmpty(student.Quiz2))
            {
                student.Quiz2 = "3.855";
            }

            if (String.IsNullOrEmpty(student.Quiz3))
            {
                student.Quiz3 = "3.735";
            }

            if (String.IsNullOrEmpty(student.Mid1))
            {
                student.Mid1 = "7.51";
            }

            if (String.IsNullOrEmpty(student.Mid2))
            {
                student.Mid2 = "7.255";
            }

            if (String.IsNullOrEmpty(student.Project))
            {
                student.Project = "8.115";
            }

            if (String.IsNullOrEmpty(student.Tutorial))
            {
                student.Tutorial = "4.045";
            }

            if (String.IsNullOrEmpty(student.FinalLab))
            {
                student.FinalLab = "7.185";
            }

            if (String.IsNullOrEmpty(student.FinalExam))
            {
                student.FinalExam = "32.725";
            }

            double total =
                Convert.ToDouble(student.Quiz1) +
                Convert.ToDouble(student.Quiz2) +
                Convert.ToDouble(student.Quiz3) +
                Convert.ToDouble(student.Mid1) +
                Convert.ToDouble(student.Mid2) +
                Convert.ToDouble(student.Project) +
                Convert.ToDouble(student.Tutorial) +
                Convert.ToDouble(student.FinalExam) +
                Convert.ToDouble(student.FinalLab);
            //student.Total = total.ToString();

            if (total >= 90)
            {
                student.Grade = "A";
            }
            else if (total >= 80 && total <= 89)
            {
                student.Grade = "B";
            }
            else if (total >= 70 && total <= 79)
            {
                student.Grade = "C";
            }
            else if (total >= 60 && total <= 69)
            {
                student.Grade = "D";
            }
            else if (total >= 0 && total <= 59)
            {
                student.Grade = "F";
            }


            return View(student);
        }


    }
}
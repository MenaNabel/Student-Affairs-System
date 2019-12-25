using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAS.Models;
using SAS.ViewModels;
namespace SAS.Controllers
{
    public class studentServicesController : Controller
    {

        // GET: studentServices
        Student_Affairs_SystemEntities1 context = new Student_Affairs_SystemEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult toGetstudentInformation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetstudentInformation(string ID , string NationalID)
        {
            if (context.students.FirstOrDefault(s => s.student_ID == ID && s.student_national_ID == NationalID) != null){
                return View(context.students.FirstOrDefault(s => s.student_ID == ID));
            }

            else
                return View("toGetstudentInformation");
        }

        [HttpPost]

        public ActionResult GetSemesterDetails(string id)
        {
            if (context.students.FirstOrDefault(s => s.student_ID == id) != null)
            {
                List<student_degree> CD = (from c in context.student_degree
                                     where c.student_ID == id
                                     select c).ToList();
                CoursesStudentsViewModel CSVM = new CoursesStudentsViewModel();
                CSVM.student = context.students.FirstOrDefault(s => s.student_ID == id);
                foreach (var item in CD)
                {
                    CoursesDegree coursesDegree = new CoursesDegree();
                    coursesDegree.ActivitesDegree = item.activites.Value;
                    coursesDegree.appreciation = item.appreciation;
                    coursesDegree.CourseName = item.course.course_name;
                    coursesDegree.FinalDegree = item.final.Value;
                    coursesDegree.GPA = item.GPA.Value;
                    coursesDegree.MidtermDegree = item.midterm.Value;
                    CSVM.courses.Add(coursesDegree);
                }
                return View(CSVM);
            }

                return View("toGetstudentInformation");
        }

        public ActionResult GetCaseReport(string id)
        {
            return View();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAS.Models;

namespace SAS.Controllers
{
    public class HomeController : Controller
    {
        Student_Affairs_SystemEntities1 context = new Student_Affairs_SystemEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AssiutUniversity()
        {
            return View();
        }

        public ActionResult SearchCoures(string courseName , string doctorName , string level)
        {
            if(courseName != null && doctorName == "" && level == null)
            {
                List<course> findCourse = (from c in context.courses
                                           where c.course_name.Contains(courseName)
                                           select c).ToList();
                if (findCourse.Count() != 0)
                    return View("../coursesDetails/displayAllCourses", findCourse);
                else
                    return View();
            }

            else if((courseName == null || courseName == "" )&& doctorName != null && level == null )
            {
                List<course> findCourse = (from c in context.courses
                                           where c.doctor_name.Contains(doctorName)
                                           select c).ToList();
                if (findCourse.Count() != 0)
                    return View("../coursesDetails/displayAllCourses", findCourse);
                else
                    return View();

            }

            else if ((courseName == null || courseName == "") && (doctorName == null || doctorName == "") && level != null)
            {
                List<course> findCourse = (from c in context.courses
                                           where c.course_level.ToString() == level
                                           select c).ToList();
                if (findCourse.Count() != 0)
                    return View("../coursesDetails/displayAllCourses", findCourse);
                else
                    return View();

            }


            else if ((courseName == null || courseName == "")  && doctorName != null && level != null)
            {
                List<course> findCourse = (from c in context.courses
                                           where c.course_level.ToString() == level && c.doctor_name.Contains(doctorName)
                                           select c).ToList();
                if (findCourse.Count() != 0)
                    return View("../coursesDetails/displayAllCourses", findCourse);
                else
                    return View();

            }

            else if (courseName != null && doctorName != null && level != null)
            {
                List<course> findCourse = (from c in context.courses
                                           where c.course_name == courseName && c.doctor_name.Contains(doctorName) && c.course_level.ToString() == level
                                           select c).ToList();
                if (findCourse.Count() != 0)
                    return View("../coursesDetails/displayAllCourses", findCourse);
                else
                    return View();
            }




            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult registerAsStudent()
        {
            return View();
        }


        public ActionResult aboutUniversity()
        {
            return View();
        }

        public ActionResult test()
        {
            return View();
        }
    }
}
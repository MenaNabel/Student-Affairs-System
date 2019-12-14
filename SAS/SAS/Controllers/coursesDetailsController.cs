using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAS.Models;
namespace SAS.Controllers
{
    public class coursesDetailsController : Controller
    {
        // GET: coursesDetails
        Student_Affairs_SystemEntities1 context = new Student_Affairs_SystemEntities1();
        public ActionResult displayAllCourses()
        {
            List<course> courses = context.courses.ToList();
            return View(courses);

        }
        public ActionResult test()
        {
            return PartialView();
        }
    }
}
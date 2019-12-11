using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAS.Models;
namespace SAS.Controllers
{
    [Authorize]
    public class administrationStaffOperationsController : Controller
    {
        Student_Affairs_SystemEntities1 context = new Student_Affairs_SystemEntities1();
        // GET: administrationStaffOperations
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult addCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addCourse(course newRecord)
        {
            course newCourse = new course();
            if(newRecord.course_code != null && newRecord.course_name != null && newRecord.course_name != null)
            {
                newCourse.course_code = newRecord.course_code;
                newCourse.course_name = newRecord.course_name;
                newCourse.doctor_name = newRecord.doctor_name;
                newCourse.course_level = newRecord.course_level;
                newCourse.course_semester = newRecord.course_semester;
                newCourse.course_hours = newRecord.course_hours;
                context.courses.Add(newCourse);
                context.SaveChanges();
                return RedirectToAction("../studentInformation/operationsucceeded");
            }
            return RedirectToAction("addCourse");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAS.Models;
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

    }
}
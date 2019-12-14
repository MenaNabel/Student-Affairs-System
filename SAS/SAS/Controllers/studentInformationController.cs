using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAS.Models;
namespace SAS.Controllers
{
    [Authorize]
    public class studentInformationController : Controller
    {
        Student_Affairs_SystemEntities1 context = new Student_Affairs_SystemEntities1();

        public ActionResult Index()
        {
            return View();
        }

        // GET: studentInformation
        [HttpGet]
        [Authorize]
        public ActionResult addStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addStudent(student newRecord)
        {
            student newStudent = new student();
            if(newRecord.student_ID != null && newRecord.student_national_ID != null && newRecord.student_name != null && newRecord.student_age != 0)
            {
                newStudent.student_ID = newRecord.student_ID;
                newStudent.student_name = newRecord.student_name;
                newStudent.student_national_ID = newRecord.student_national_ID;
                newStudent.student_age = newRecord.student_age;
                newStudent.student_adress = newRecord.student_adress;
                newStudent.student_level = 1;
                newStudent.student_phone = newRecord.student_phone;
                newStudent.student_email = newRecord.student_email;
                context.students.Add(newStudent);
                context.SaveChanges();
                return RedirectToAction("operationsucceeded");
            }
            return RedirectToAction("addStudent");
        }

        public ActionResult toEditInformationStudent()
        {
            return View();
        }
        [HttpGet]
        public ActionResult editInformationStudent(string student_ID)
        {
            if (context.students.FirstOrDefault(s => s.student_ID == student_ID) != null)
                return View(context.students.FirstOrDefault(s => s.student_ID.Equals(student_ID)));
            else
                return View("toEditInformationStudent");
        }

        [HttpPost]
        public ActionResult editInformationStudent(string ID , student editRecord)
        {
            
                student editRecordStudent = context.students.FirstOrDefault(s => s.student_ID == ID);
                if (editRecord.student_name != null)
                    editRecordStudent.student_name = editRecord.student_name;
                if (editRecord.student_adress != null)
                    editRecordStudent.student_adress = editRecord.student_adress;
                if (editRecord.student_phone != null)
                    editRecordStudent.student_phone = editRecord.student_phone;
                context.SaveChanges();
                return RedirectToAction("operationsucceeded");
            
        }
        public ActionResult operationsucceeded()
        {
            return View();
        }

    }
}
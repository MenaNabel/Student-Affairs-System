using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SAS.Models;
using SAS.ViewModels;

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
            if (newRecord.course_code != null && newRecord.course_name != null && newRecord.course_name != null)
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

        public ActionResult getStudent()
        {
            return View();
        }

        public ActionResult ShowAllCoursesAvailable(string id)
        {
            //if (id != null)
            //{
            //    CoursesAvailabelToStudentViewModel CAS = new CoursesAvailabelToStudentViewModel();
            //    CAS.student = context.students.FirstOrDefault(s => s.student_ID == id);
            //    if (CAS.student != null)
            //    {
            //        if (CAS.student.student_level == 1)
            //        {
            //            CAS.coursesAvailable = context.courses.Where(l => l.course_level == 1 && l.course_semester == 1).ToList();
            //            return View(CAS);
            //        }
            //        else
            //        {
            //            int level = CAS.student.student_level;
            //            List<course> coursesAvailabale = (from c in context.courses
            //                                              where c.course_level == level
            //                                              select c).ToList();

            //        }
            //    }

            if (id != null)
            {
                CoursesAvailabelToStudentViewModel CAS2 = new CoursesAvailabelToStudentViewModel();
                CAS2.student = context.students.FirstOrDefault(s => s.student_ID == id);
                if (CAS2.student != null)
                {
                    CAS2.coursesAvailable = (from c in context.student_available_course
                                             where c.student_ID == id
                                             select context.courses.FirstOrDefault(CA => CA.course_code == c.course_ID)).ToList();
                    return View(CAS2);
                }
            }
            return View("getStudent");
            
}

        public ActionResult registerToStudent(string id , CoursesAvailabelToStudentViewModel CATS)
        {
            foreach (var item in CATS.coursesAvailableList)
            {
                student_available_course SAC = new student_available_course();
                    SAC.course_ID = context.courses.FirstOrDefault(c => c.course_name == item).course_code;
                    SAC.student_ID = context.students.FirstOrDefault(s => s.student_ID == id).student_ID;
                    context.student_available_course.Add(SAC);
                    context.SaveChanges();
            }
            return RedirectToAction("getStudent");
        }

        [HttpGet]
        public ActionResult insertDegreesToStudent()
        {
            return View();
        }


        [HttpPost]
        public ActionResult insertDegreesToStudent(student_degree SD)
        {
            if(context.students.FirstOrDefault(s=>s.student_ID == SD.student_ID) != null && context.courses.FirstOrDefault(c => c.course_code == SD.course_ID) != null && (SD.activites + SD.midterm + SD.practical <= 50) && (SD.activites + SD.final + SD.midterm + SD.practical <= 100))
            {
                student_degree newSD = new student_degree { student_ID = SD.student_ID, course_ID = SD.course_ID, final = SD.final, practical = SD.practical, midterm = SD.midterm, activites = SD.activites };
                newSD.GPA = Convert.ToDecimal(CoursesFCI.CalGPA(Convert.ToDouble(newSD.activites + newSD.final + newSD.midterm + newSD.practical)));
                newSD.appreciation = CoursesFCI.CalAppreciation(Convert.ToDouble(newSD.GPA));
                context.student_degree.Add(newSD);
                context.SaveChanges();
                bool isSuccess = CoursesFCI.isSuccess(newSD.appreciation);
                if(isSuccess)
                {
                    student_available_course RemoveCourse = context.student_available_course.FirstOrDefault(c => c.course_ID == newSD.course_ID);
                    context.student_available_course.Remove(RemoveCourse);
                    context.SaveChanges();
                }
                return RedirectToAction("../studentInformation/operationsucceeded");

            }
            return View("insertDegreesToStudent");
        }

    }
}
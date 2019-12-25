using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAS.Models;

namespace SAS
{
    public class CoursesAvailable
    {
        private static Student_Affairs_SystemEntities1 context = new Student_Affairs_SystemEntities1();
        public static void CoursesAvailableForStudent(string id)
        {
            int level = context.students.FirstOrDefault(s=>s.student_ID == id).student_level;
            List<course> coursesAvailabaleForStudent = (from c in context.courses
                                              where c.course_level == level
                                              select c).ToList();
            //List<string> RemainingCourses = (from c in context.student_available_course
            //                                 where c.student_ID == id
            //                                 select c.course_ID).ToList();
            //List<prequest_course> PC = context.prequest_course.ToList();
            //foreach (var item in coursesAvailabaleForStudent)
            //{
            //    foreach (var itemPC in PC)
            //    {
            //        if ()
            //}
            //}

            foreach (var item in coursesAvailabaleForStudent)
            {
                student_available_course SAC = new student_available_course();
                SAC.student_ID = id;
                SAC.course_ID = item.course_code;
                context.student_available_course.Add(SAC);
                context.SaveChanges();
            }
        }

        public static void EndTerm(student_degree SD)
        {
            student_case_report SCR = new student_case_report() { student_ID = SD.student_ID, course_ID = SD.course_ID, appreciation = SD.appreciation, GPA = SD.GPA.Value, total_degree = (SD.midterm.Value + SD.practical.Value + SD.activites.Value + SD.final.Value)};
            context.student_case_report.Add(SCR);
            if(SD.student.student_term == 1)
                //ممكن تطلع غلط
                SD.student.student_term++;
            else
                SD.student.student_level++;
            context.SaveChanges();
        }

    }
}
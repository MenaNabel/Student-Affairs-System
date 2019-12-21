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

    }
}
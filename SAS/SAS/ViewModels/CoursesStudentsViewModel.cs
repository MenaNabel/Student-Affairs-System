using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAS.Models;

namespace SAS.ViewModels
{
    public class CoursesStudentsViewModel
    {
        public List<CoursesDegree> courses { get; set; }
        public student student { get; set; }
        public CoursesStudentsViewModel()
        {
            courses = new List<CoursesDegree>();
            student = new student();
        }

    }
}
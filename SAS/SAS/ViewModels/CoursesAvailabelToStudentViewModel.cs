using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAS.Models;

namespace SAS.ViewModels
{
    public class CoursesAvailabelToStudentViewModel
    {
        public List<course> coursesAvailable { get; set; }
        public student student { get; set; }
        public List<string> coursesAvailableList { get; set; }
        public CoursesAvailabelToStudentViewModel()
        {
            coursesAvailable = new List<course>();
            student = new student();
            coursesAvailableList = new List<string>();
        }
    }
}
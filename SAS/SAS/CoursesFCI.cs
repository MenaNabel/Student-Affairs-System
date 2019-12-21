using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAS
{
    public class CoursesFCI
    {
        public static double CalGPA(double degree)
        {
            if (degree >= 90)
                return 4.0;
            else if (degree < 90 && degree >= 85)
                return 3.7;
            else if (degree < 85 && degree > 80)
                return 3.3;
            else if (degree < 80 && degree >= 75)
                return 3.0;
            else if (degree < 75 && degree >= 70)
                return 2.7;
            else if (degree < 70 && degree >= 65)
                return 2.3;
            else if (degree < 65 && degree >= 60)
                return 2.0;
            else if (degree < 60 && degree >= 55)
                return 1.7;
            else if (degree < 55 && degree >= 50)
                return 1.3;
            else if (degree < 50 && degree >= 45)
                return 1.0;
            else
                return 0.0;
        }



        public static string CalAppreciation(double GPA)
        {
            if (GPA == 4.0)
                return "A";
            else if (GPA == 3.7)
                return "A-";
            else if (GPA == 3.3)
                return "B+";
            else if (GPA == 3.0)
                return "B";
            else if (GPA == 2.7)
                return "B-";
            else if (GPA == 2.3)
                return "C+";
            else if (GPA == 2.0)
                return "C";
            else if (GPA == 1.7)
                return "C-";
            else if (GPA == 1.3)
                return "D+";
            else if (GPA == 1.0)
                return "D";
            else
                return "F";
        }

        public static bool isSuccess(string appreciation)
        {
            if (appreciation != "F")
                return true;
            else
                return false;
        }
    }
}
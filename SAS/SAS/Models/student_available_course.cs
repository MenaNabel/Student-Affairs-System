//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student_available_course
    {
        public int ID { get; set; }
        public string student_ID { get; set; }
        public string course_ID { get; set; }
    
        public virtual student student { get; set; }
        public virtual course course { get; set; }
    }
}

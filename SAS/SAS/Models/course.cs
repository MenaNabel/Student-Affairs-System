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
    
    public partial class course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public course()
        {
            this.prequest_course = new HashSet<prequest_course>();
            this.prequest_course1 = new HashSet<prequest_course>();
            this.student_case_report = new HashSet<student_case_report>();
            this.student_degree = new HashSet<student_degree>();
        }
    
        public string course_code { get; set; }
        public string course_name { get; set; }
        public int course_level { get; set; }
        public int course_semester { get; set; }
        public string doctor_name { get; set; }
        public int course_hours { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prequest_course> prequest_course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prequest_course> prequest_course1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student_case_report> student_case_report { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student_degree> student_degree { get; set; }
    }
}

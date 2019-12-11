using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAS.Models
{
    /*[MetadataType(typeof(student))]
    public partial class student
    {

    }
    public class studentMetaData
    {
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(14, ErrorMessage = "doesn't allowe to enter more than 10 number")]
        [MinLength(14, ErrorMessage = "doesn't allowe to enter less than 9 number")]
        [RegularExpression("[^0-9]", ErrorMessage = "Enter numerric only")]
        public string ID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(14, ErrorMessage = "doesn't allowe to enter more than 14 number")]
        [MinLength(14, ErrorMessage = "doesn't allowe to enter less than 14 character")]
        [RegularExpression("[^0-9]", ErrorMessage = "Enter numerric only")]
        public string NationalID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 250 character")]
        [MinLength(250, ErrorMessage = "doesn't allowe to enter less than 5 character")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string name { get; set; }
        [EmailAddress(ErrorMessage = "Enter correct email @example.com")]
        [RegularExpression(@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$", ErrorMessage = "Invalid email")]
        public string email { get; set; }
        [RegularExpression("[^0-9]", ErrorMessage = "Enter numerric only")]
        public int age { get; set; }
        [MaxLength(11, ErrorMessage = "Enter 11 number only")]
        [MinLength(11, ErrorMessage = "Enter 11 number only")]
        [RegularExpression("[^0-9]", ErrorMessage = "Enter numerric only")]
        public string phone { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 250 character")]
        [MinLength(250, ErrorMessage = "doesn't allowe to enter less than 5 character")]
        public string address { get; set; }
        
    }*/
}
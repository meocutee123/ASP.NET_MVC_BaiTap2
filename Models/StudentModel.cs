using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaiTap2.Models
{
    public class StudentModel
    {
        [Display(Name = "Student number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student number required!")]
        public string studentNub { get; set; }
        [Display(Name = "Student name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student name required!")]
        public string studentName { get; set; }
        [Display(Name = "Student score")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Student score required!")]
        public float studentScore { get; set; }
    }
}
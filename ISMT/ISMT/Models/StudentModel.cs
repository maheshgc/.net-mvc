using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ISMT.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        [StringLength(60, MinimumLength = 10, ErrorMessage ="Custom Error Message")]
        public string StudentAddress { get; set; }
    }
}

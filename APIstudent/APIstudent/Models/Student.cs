using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIStudent.Models
{
    public class Student
    {
        [Key]
        [Required]
        [Range(1, 9999)]
        public int StudentID { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string LastName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must contain between {2} and {1} characters", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

    }
}
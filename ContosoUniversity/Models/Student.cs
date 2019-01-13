using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50, MinimumLength =1, ErrorMessage ="First name cannot be longer than 50 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage ="Must start with an Upper case letter, and all must be alpha characters")]
        [Column("FirstName")]
        [Required]
        [Display(Name ="First Name")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]        
        public DateTime EnrollmentDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get { return LastName + " " + FirstMidName; } }
        public ICollection<Enrollment> Enrollments { get; set; }


      
    }

    
}

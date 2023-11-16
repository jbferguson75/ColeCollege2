using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ColeCollege.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "Student Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Student First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Student Enrollment")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

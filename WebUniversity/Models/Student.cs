using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// DataAnnotations deals with front end 
// https://msdn.microsoft.com/en-us/library/ee256141(v=vs.98).aspx
// https://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations(v=vs.110).aspx
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [StringLength(50)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName {
            get { return LastName + ", " + FirstName; } }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

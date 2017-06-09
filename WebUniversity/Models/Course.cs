using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebUniversity.Models
{
    public class Course
    {
        // Don't handle the auto assigning of a primary key.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0,5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public Department Department { get; set; }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
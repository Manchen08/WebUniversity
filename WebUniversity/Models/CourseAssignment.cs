using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebUniversity.Models
{
    public class CourseAssignment
    {
        // Primary key is defined in SchoolContext.cs

        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
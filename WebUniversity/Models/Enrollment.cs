﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebUniversity.Models
{
    public enum Grade { A,B,C,D,E}
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Grade? Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kida_1.Models
{
    public class StudentCourse
    {
        public int id { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kida_1.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }

        public ICollection<StudentCourse> Enrollment { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string fullName { get; set; }

        public float GPA { get; set; }

        [MaxLength(12)]
        public string favoriteSubject { get; set; }

        public int Age { get; set; }
    }
}

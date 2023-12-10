﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student
    {
        public long StudentId { get; set; }
        public long SubjectId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Age { get; set; }
        public string? PhoneNo { get; set; }
        public string? Units { get; set; }
    }
}

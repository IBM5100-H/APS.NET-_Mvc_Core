﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_web.Model
{
    public class Student
    {
        public int Id { get; set; }


        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime BirthDate { get; set; }


        public Gender Gender { get; set; }
    }
}

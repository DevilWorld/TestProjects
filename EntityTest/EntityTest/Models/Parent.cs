﻿using System;
using System.Collections.Generic;
using EntityTest.Models;

namespace EntityTest.Models
{
    public class Parent
    {
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        //Navigation Property
        public virtual ICollection<Address> Addresses { get; set; }

        //Navigation Property
        public virtual ICollection<Student> Students { get; set; }
    }
}

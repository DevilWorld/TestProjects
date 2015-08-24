using EntityTest.Models;
using System;
using System.Collections.Generic;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\dinesh.venkatachalam\Source\MyRepos\TestProjects\EntityTest\EntityTest\App_Data");
            
            using (var _context = new EntityContext())
            {
                var _student = new Student
                {
                    FirstName = "Dinesh",
                    MiddleName = "R",
                    LastName = "Venkatachalam",
                    Sex = "M",
                    DOB = DateTime.Now.AddYears(30),
                    Addresses = new List<Address> {
                        new Address { Address1 = "5012 Shadowood Pkwy",
                        Address2 = string.Empty,
                        City = "Atlanta",
                        State = "GA",
                        Zip = 31220
                        }
                    }
                };


                _context.Student.Add(_student);
                _context.SaveChanges();
            }
        }
    }
}

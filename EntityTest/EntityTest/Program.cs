using EntityTest.Models;
using System;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\Dinesh\Source\Repos\TestProjects\EntityTest\EntityTest\App_Data");

            using (var _context = new EntityContext())
            {
                StudentAddresses _student = new StudentAddresses
                {
                    Student = new Student
                    {
                        FirstName = "Dinesh",
                        MiddleName = "R",
                        LastName = "Venkatachalam",
                        Sex = "M",
                        DOB = DateTime.Now.AddYears(30)
                    },
                    Address = new Address
                    {
                        Address1 = "5012 Shadowood Pkwy",
                        Address2 = string.Empty,
                        City = "Atlanta",
                        State = "GA",
                        Zip = 31220
                    }
                };

                _context.StudentAddresses.Add(_student);
                _context.SaveChanges();
            }
        }
    }
}

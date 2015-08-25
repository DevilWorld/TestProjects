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


                //_context.Student.Add(_student);
                var _parent = new Parent
                {
                    FirstName = "Robert",
                    MiddleName = "",
                    LastName = "Clive",
                    Gender = "M",
                    DOB = DateTime.Now.AddYears(-70),
                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            Address1 = "2310 Prestigious Lane",
                        Address2 = string.Empty,
                        City = "Charlotte",
                        State = "NC",
                        Zip = 28269
                        }
                    }
                };

                //_context.Parent.Add(_parent);

                var _parentstudent = new Parent
                {
                    FirstName = "Tom",
                    MiddleName = "",
                    LastName = "Royd",
                    Gender = "M",
                    DOB = DateTime.Now.AddYears(-60),
                    Students = new List<Student>
                    {
                        new Student
                        {
                            FirstName = "Fredrick",
                            MiddleName = "R",
                            LastName = "Lieu",
                            Sex = "M",
                            DOB = DateTime.Now.AddYears(20),
                        }
                    }
                };

                //_context.Parent.Add(_parentstudent);

                var _principal = new Principal
                {
                    FirstName = "Jim",
                    MiddleName = "J",
                    LastName = "Jack",
                    Gender = "M",
                    DOB = DateTime.Now.AddYears(-60),
                    Address = new Address
                    {
                        Address1 = "2310 Prestigious Lane",
                        Address2 = string.Empty,
                        City = "Charlotte",
                        State = "NC",
                        Zip = 28269
                    }
                };

                _context.Principal.Add(_principal);
                _context.SaveChanges();
            }
        }
    }
}

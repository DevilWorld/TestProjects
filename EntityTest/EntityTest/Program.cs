using EntityTest.Models;
using System;
using System.Collections.Generic;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\Dinesh\Source\Repos\TestProjects\EntityTest\EntityTest\App_Data");

            using (var _context = new EntityContext())
            {
                var _student = new Student
                {
                    FirstName = "Dineshhhh",
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
                    PrincipalAddress = new PrincipalAddress
                    {
                        Address1 = "2310 Prestigious Lane1",
                        Address2 = string.Empty,
                        City = "Charlotte",
                        State = "NC",
                        Zip = 28269
                    }
                };

                //_context.Principal.Add(_principal);

                //var _school = new School
                //{
                //    SchoolName = "BMHSS",
                //    Principal = _principal,
                //    SchoolAddress = new Address
                //    {
                //        Address1 = "2310 Prestigious Lane",
                //        Address2 = string.Empty,
                //        City = "Charlotte",
                //        State = "NC",
                //        Zip = 28269
                //    }
                //};

                var _school = new School
                {
                    SchoolName = "BMHSS",
                    Address1 = "2310 Prestigious Lane12",
                    Address2 = string.Empty,
                    City = "Charlotte",
                    State = "NC",
                    Zip = 28269,
                    Principal = _principal
                };

                //_context.School.Add(_school);
                

                var _teacher = new Teachers
                {
                    FirstName = "Suresh",
                    MiddleName = "S",
                    LastName = "Kumar",
                    Gender = "M",
                    DOB = DateTime.Now.AddYears(40),
                    TeacherAddress = new Address
                    {
                        Address1 = "2310 Prestigious Lane2",
                        Address2 = string.Empty,
                        City = "Charlotte",
                        State = "NC",
                        Zip = 28269
                    },
                    School = _school
                };
                //_context.Teacher.Add(_teacher);


                var _subject = new Subject
                {
                    SubjectName = "English"
                };

                //_context.Subject.Add(_subject);

                var _class = new Class
                {
                    ClassName = "Eigth Standard",
                    Subject = _subject,
                    Teacher = _teacher,
                    TeacherFromDate = DateTime.Now.AddMonths(-5),
                    TeacherToDate = DateTime.Now
                };

                //_context.Class.Add(_class);

                var _studentClass = new StudentClasses
                {
                    Student = _student,
                    Class = _class,
                    FromDate = DateTime.Now,
                    ToDate = DateTime.Now
                };
                _context.StudentClass.Add(_studentClass);
                _context.SaveChanges();
            }
        }
    }
}

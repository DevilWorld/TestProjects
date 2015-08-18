using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AngularJS3.Models;

namespace AngularJS3.Models
{
    public class PersonRepository
    {
        public Person[] GetPersons()
        {
            var persons = new[]
            {
                new Person {Id = 1, Name = "Gilbert"},
                new Person {Id = 2, Name = "Frank"}
            };

            return persons;
        }
    }
}
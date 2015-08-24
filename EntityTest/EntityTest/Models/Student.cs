using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }

        //Navigation property, which acts as a collection of the child
        public ICollection<StudentAddresses> StudentAddress { get; set; }
    }
}

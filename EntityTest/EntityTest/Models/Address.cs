using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    class Address
    {
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set;}
        public int Zip { get; set; }

        //Navigation property
        public ICollection<StudentAddresses> StudentAddress { get; set; }
    }
}

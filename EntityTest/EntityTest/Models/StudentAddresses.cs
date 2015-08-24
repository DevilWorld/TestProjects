using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    class StudentAddresses
    {
        public int StudentAddressesId { get; set; }

        //Foreign Key property
        public int StudentId { get; set; }
        //Navigation Porperty
        public Student Student { get; set; }

        //Foreign Key Property
        public int AddressId { get; set; }
        //Navigation Property
        public Address Address { get; set; }
    }
}

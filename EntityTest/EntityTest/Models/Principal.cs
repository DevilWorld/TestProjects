using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTest.Models
{
    class Principal
    {
        public int PrincipalId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        //Navigation property....One-to-one relationship
        public virtual Address Address { get; set; }

        //Foreign Key property
        public int AddressId { get; set; }
    }
}

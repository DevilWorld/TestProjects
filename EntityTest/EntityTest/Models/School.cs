using System;

namespace EntityTest.Models
{
    class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public int SchoolAddressId { get; set; }
        public int PrinciId { get; set; }

        //Navigation Property 
        public Principal Principal { get; set; }

        public Address SchoolAddress { get; set; }
    }
}

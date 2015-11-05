using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_100513_01
    {
        public int CABS_100513_01ID { get; set; }
        public string RECORD_IDENTIFICATION { get; set; }
        public string RECORD_IDENTIFICATION_SUFFIX { get; set; }
        public string SUFFIX_RECORD_IND { get; set; }
        public string ACCESS_CUSTOMER_NAME_ABBREVIATION { get; set; }
        public string BILL_DATE { get; set; }
        public string BILLING_NUMBER { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string PACK_SEQUENCE_NUMBER { get; set; }
        public string RECORD_SEQUENCE_NUMBER { get; set; }
        public string RESERVED_FOR_EC_USE { get; set; }
        public double TOTAL_OTHER_CHARGES_AND_CREDITS_LOCAL { get; set; }
        public double TOTAL_USAGE_CHARGES_LOCAL { get; set; }
    }
}

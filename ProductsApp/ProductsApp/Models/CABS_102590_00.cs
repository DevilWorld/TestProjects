using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_102590_00
    {
        public int CABS_102590_00ID { get; set; }
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
        public double TOTAL_BALANCE_DUE { get; set; }
    }
}

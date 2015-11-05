using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_103025_00
    {
        public int CABS_103025_00ID { get; set; }
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
        public double USO_NET_CHANGE { get; set; }
        public double USO_FRACTIONAL_AMOUNT { get; set; }
        public double USO_ONE_TIME_AMOUNT { get; set; }
        public double USO_BILLED_AMOUNT { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_103015_00
    {
        public int CABS_103015_00ID { get; set; }
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
        public double OCC_AMOUNT_INTERSTATE { get; set; }
        public double OCC_AMOUNT_INTRASTATE { get; set; }
        public double OCC_AMOUNT_INTERSTATE_INTRALATA { get; set; }
        public double OCC_AMOUNT_INTRASTATE_INTRALATA { get; set; }
        public double OCC_AMOUNT_NON_JURISDICTIONAL { get; set; }
        public double OCC_PHRASE_QUANTITY { get; set; }
        public double OCC_PHRASE_AMOUNT { get; set; }
    }
}

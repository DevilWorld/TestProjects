using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_100513_00
    {
        public int CABS_100513_00ID { get; set; }
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
        public double TOTAL_OTHER_CHARGES_AND_CREDITS { get; set; }
        public double TOTAL_OTHER_CHARGES_AND_CREDITS_INTERSTATE { get; set; }
        public double TOTAL_OTHER_CHARGES_AND_CREDITS_INTRASTATE { get; set; }
        public double TOTAL_OTHER_CHARGES_AND_CREDITS_NON_JURISDICTIONAL { get; set; }
        public double TOTAL_USAGE_CHARGES { get; set; }
        public double TOTAL_USAGE_CHARGES_INTERSTATE { get; set; }
        public double TOTAL_USAGE_CHARGES_INTRASTATE { get; set; }
        public double TOTAL_TAXES { get; set; }
        public double TOTAL_CURRENT_CHARGES { get; set; }
        public double TOTAL_AMOUNT_DUE { get; set; }
        public double TOTAL_SURCHARGES { get; set; }
        public double TOTAL_PAYMENT_PLAN_CHARGES { get; set; }
    }
}

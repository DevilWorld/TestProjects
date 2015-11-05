using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_401535_00
    {
        public int CABS_401535_00ID { get; set; }
        public int UniqueRecord { get; set; }
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
        public double CSR_ACCOUNT_TOTAL { get; set; }
        public double INTERSTATE_TOTAL { get; set; }
        public double INTRASTATE_TOTAL { get; set; }
        public string STATE_INDICATOR { get; set; }
        public string STATE_LEVEL_COMPANY_CODE { get; set; }
        public string MPB_COMPANY_CODE { get; set; }
        public string RESERVED1 { get; set; }
        public double INTERSTATE_TOTAL_PAYMENT_PLAN { get; set; }
        public double INTRASTATE_TOTAL_PAYMENT_PLAN { get; set; }
        public double CSR_ACCOUNT_TOTAL_PAYMENT_PLAN { get; set; }
        public double LOCAL_TOTAL { get; set; }
        public string RESERVED2 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_100510_00
    {
        public int CABS_100510_00ID { get; set; }
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
        public string RESERVED1 { get; set; }
        public string INVOICE_NUMBER { get; set; }
        public string RESERVED2 { get; set; }
        public double TOTAL_AMOUNT_LAST_BILL { get; set; }
        public double PAYMENTS_APPLIED { get; set; }
        public double ADJUSTMENTS_APPLIED_TOTAL { get; set; }
        public double ADJUSTMENTS_APPLIED_INTERSTATE { get; set; }
        public double ADJUSTMENTS_APPLIED_INTRASTATE { get; set; }
        public double ADJUSTMENTS_APPLIED_NON_JURISDICTIONAL { get; set; }
        public double TOTAL_BALANCE_DUE { get; set; }
        public string MPB_COMPANY_CODE { get; set; }
        public double ADJUSTMENTS_APPLIED_LOCAL { get; set; }
        public string RESERVED3 { get; set; }
    }
}

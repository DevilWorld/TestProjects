using System;
using System.Collections.Generic;

namespace ProductsApp.Models
{
    public partial class CABS_401520_00
    {
        public int ID { get; set; }
        public int CABS_401520_00ID { get; set; }
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
        public string USOC_QUANTITY { get; set; }
        public string INTERSTATE_PERCENTAGE { get; set; }
        public double INTERSTATE_UNIT_RATE { get; set; }
        public double INTERSTATE_BILLED_AMOUNT { get; set; }
        public string INTRASTATE_PERCENTAGE { get; set; }
        public double INTRASTATE_UNIT_RATE { get; set; }
        public double INTRASTATE_BILLED_AMOUNT { get; set; }
        public string BIP { get; set; }
        public string FACILITY_CHARGE_TYPE_IND { get; set; }
        public string RATE_ZONE_IND_INTERSTATE { get; set; }
        public string RATE_SUB_ZONE_IND_INTERSTATE { get; set; }
        public string PORT_TYPE_IND_DETAIL { get; set; }
        public string MARKET_RATE_TYPE_IND { get; set; }
        public string RESERVED { get; set; }
        public string STATE_IND { get; set; }
        public string SPECIALIZED_TRANSITION_PERCENT { get; set; }
        public string STATE_LEVEL_COMPANY_CODE { get; set; }
        public string WIRELESS_PERCENT_ORIGINATING_USAGE { get; set; }
        public string RATCHET_FACTOR { get; set; }
        public string PRICING_FLEX_BAND_2 { get; set; }
        public string PRICING_FLEX_IND_INTERSTATE_INTRALATA { get; set; }
        public string PRICING_FLEX_IND_INTERSTATE { get; set; }
        public string PRICING_FLEX_IND_INTRASTATE { get; set; }
        public string PRICING_FLEX_IND_INTRASTATE_INTRALATA { get; set; }
        public string PRICING_FLEX_BAND { get; set; }
        public string RATE_ZONE_IND_INTRASTATE { get; set; }
        public string PERCENT_TWO_WAY_CONNECTING_CIRCUITS { get; set; }
        public string MID_SPAN_PERCENT { get; set; }
        public string DISCOUNT_FACTOR_INTERSTATE { get; set; }
        public string DISCOUNT_FACTOR_INTRASTATE { get; set; }
        public double LOCAL_UNIT_RATE { get; set; }
        public double LOCAL_BILLED_AMOUNT { get; set; }
        public string OVERRIDE_LOCAL_RATING_PERCENT { get; set; }
        public string USOC_QUANTITY_QTY { get; set; }
        public string ACCESS_TYPE_IND { get; set; }
        public string LOCAL_PERCENTAGE { get; set; }
        public string RATE_ZONE_IND_LOCAL { get; set; }
        public string SUPPLEMENTAL_BIP { get; set; }
    }
}

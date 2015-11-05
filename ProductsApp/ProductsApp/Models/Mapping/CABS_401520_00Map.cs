using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_401520_00Map : EntityTypeConfiguration<CABS_401520_00>
    {
        public CABS_401520_00Map()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_401520_00");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CABS_401520_00ID).HasColumnName("CABS_401520_00ID");
            this.Property(t => t.RECORD_IDENTIFICATION).HasColumnName("RECORD_IDENTIFICATION");
            this.Property(t => t.RECORD_IDENTIFICATION_SUFFIX).HasColumnName("RECORD_IDENTIFICATION_SUFFIX");
            this.Property(t => t.SUFFIX_RECORD_IND).HasColumnName("SUFFIX_RECORD_IND");
            this.Property(t => t.ACCESS_CUSTOMER_NAME_ABBREVIATION).HasColumnName("ACCESS_CUSTOMER_NAME_ABBREVIATION");
            this.Property(t => t.BILL_DATE).HasColumnName("BILL_DATE");
            this.Property(t => t.BILLING_NUMBER).HasColumnName("BILLING_NUMBER");
            this.Property(t => t.CUSTOMER_CODE).HasColumnName("CUSTOMER_CODE");
            this.Property(t => t.PACK_SEQUENCE_NUMBER).HasColumnName("PACK_SEQUENCE_NUMBER");
            this.Property(t => t.RECORD_SEQUENCE_NUMBER).HasColumnName("RECORD_SEQUENCE_NUMBER");
            this.Property(t => t.RESERVED_FOR_EC_USE).HasColumnName("RESERVED_FOR_EC_USE");
            this.Property(t => t.USOC_QUANTITY).HasColumnName("USOC_QUANTITY");
            this.Property(t => t.INTERSTATE_PERCENTAGE).HasColumnName("INTERSTATE_PERCENTAGE");
            this.Property(t => t.INTERSTATE_UNIT_RATE).HasColumnName("INTERSTATE_UNIT_RATE");
            this.Property(t => t.INTERSTATE_BILLED_AMOUNT).HasColumnName("INTERSTATE_BILLED_AMOUNT");
            this.Property(t => t.INTRASTATE_PERCENTAGE).HasColumnName("INTRASTATE_PERCENTAGE");
            this.Property(t => t.INTRASTATE_UNIT_RATE).HasColumnName("INTRASTATE_UNIT_RATE");
            this.Property(t => t.INTRASTATE_BILLED_AMOUNT).HasColumnName("INTRASTATE_BILLED_AMOUNT");
            this.Property(t => t.BIP).HasColumnName("BIP");
            this.Property(t => t.FACILITY_CHARGE_TYPE_IND).HasColumnName("FACILITY_CHARGE_TYPE_IND");
            this.Property(t => t.RATE_ZONE_IND_INTERSTATE).HasColumnName("RATE_ZONE_IND_INTERSTATE");
            this.Property(t => t.RATE_SUB_ZONE_IND_INTERSTATE).HasColumnName("RATE_SUB_ZONE_IND_INTERSTATE");
            this.Property(t => t.PORT_TYPE_IND_DETAIL).HasColumnName("PORT_TYPE_IND_DETAIL");
            this.Property(t => t.MARKET_RATE_TYPE_IND).HasColumnName("MARKET_RATE_TYPE_IND");
            this.Property(t => t.RESERVED).HasColumnName("RESERVED");
            this.Property(t => t.STATE_IND).HasColumnName("STATE_IND");
            this.Property(t => t.SPECIALIZED_TRANSITION_PERCENT).HasColumnName("SPECIALIZED_TRANSITION_PERCENT");
            this.Property(t => t.STATE_LEVEL_COMPANY_CODE).HasColumnName("STATE_LEVEL_COMPANY_CODE");
            this.Property(t => t.WIRELESS_PERCENT_ORIGINATING_USAGE).HasColumnName("WIRELESS_PERCENT_ORIGINATING_USAGE");
            this.Property(t => t.RATCHET_FACTOR).HasColumnName("RATCHET_FACTOR");
            this.Property(t => t.PRICING_FLEX_BAND_2).HasColumnName("PRICING_FLEX_BAND_2");
            this.Property(t => t.PRICING_FLEX_IND_INTERSTATE_INTRALATA).HasColumnName("PRICING_FLEX_IND_INTERSTATE_INTRALATA");
            this.Property(t => t.PRICING_FLEX_IND_INTERSTATE).HasColumnName("PRICING_FLEX_IND_INTERSTATE");
            this.Property(t => t.PRICING_FLEX_IND_INTRASTATE).HasColumnName("PRICING_FLEX_IND_INTRASTATE");
            this.Property(t => t.PRICING_FLEX_IND_INTRASTATE_INTRALATA).HasColumnName("PRICING_FLEX_IND_INTRASTATE_INTRALATA");
            this.Property(t => t.PRICING_FLEX_BAND).HasColumnName("PRICING_FLEX_BAND");
            this.Property(t => t.RATE_ZONE_IND_INTRASTATE).HasColumnName("RATE_ZONE_IND_INTRASTATE");
            this.Property(t => t.PERCENT_TWO_WAY_CONNECTING_CIRCUITS).HasColumnName("PERCENT_TWO_WAY_CONNECTING_CIRCUITS");
            this.Property(t => t.MID_SPAN_PERCENT).HasColumnName("MID_SPAN_PERCENT");
            this.Property(t => t.DISCOUNT_FACTOR_INTERSTATE).HasColumnName("DISCOUNT_FACTOR_INTERSTATE");
            this.Property(t => t.DISCOUNT_FACTOR_INTRASTATE).HasColumnName("DISCOUNT_FACTOR_INTRASTATE");
            this.Property(t => t.LOCAL_UNIT_RATE).HasColumnName("LOCAL_UNIT_RATE");
            this.Property(t => t.LOCAL_BILLED_AMOUNT).HasColumnName("LOCAL_BILLED_AMOUNT");
            this.Property(t => t.OVERRIDE_LOCAL_RATING_PERCENT).HasColumnName("OVERRIDE_LOCAL_RATING_PERCENT");
            this.Property(t => t.USOC_QUANTITY_QTY).HasColumnName("USOC_QUANTITY_QTY");
            this.Property(t => t.ACCESS_TYPE_IND).HasColumnName("ACCESS_TYPE_IND");
            this.Property(t => t.LOCAL_PERCENTAGE).HasColumnName("LOCAL_PERCENTAGE");
            this.Property(t => t.RATE_ZONE_IND_LOCAL).HasColumnName("RATE_ZONE_IND_LOCAL");
            this.Property(t => t.SUPPLEMENTAL_BIP).HasColumnName("SUPPLEMENTAL_BIP");
        }
    }
}

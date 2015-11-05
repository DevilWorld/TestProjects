using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_401521_00Map : EntityTypeConfiguration<CABS_401521_00>
    {
        public CABS_401521_00Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_401521_00ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_401521_00");
            this.Property(t => t.CABS_401521_00ID).HasColumnName("CABS_401521_00ID");
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
            this.Property(t => t.INTERSTATE_INITIAL_MILEAGE_RATE).HasColumnName("INTERSTATE_INITIAL_MILEAGE_RATE");
            this.Property(t => t.INTERSTATE_UNIT_RATE_MILEAGE).HasColumnName("INTERSTATE_UNIT_RATE_MILEAGE");
            this.Property(t => t.INTERSTATE_BILLED_AMOUNT).HasColumnName("INTERSTATE_BILLED_AMOUNT");
            this.Property(t => t.INTRASTATE_INITIAL_MILEAGE_RATE).HasColumnName("INTRASTATE_INITIAL_MILEAGE_RATE");
            this.Property(t => t.INTRASTATE_UNIT_RATE_MILEAGE).HasColumnName("INTRASTATE_UNIT_RATE_MILEAGE");
            this.Property(t => t.INTRASTATE_BILLED_AMOUNT).HasColumnName("INTRASTATE_BILLED_AMOUNT");
        }
    }
}

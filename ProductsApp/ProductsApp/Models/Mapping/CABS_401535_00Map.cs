using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_401535_00Map : EntityTypeConfiguration<CABS_401535_00>
    {
        public CABS_401535_00Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_401535_00ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_401535_00");
            this.Property(t => t.CABS_401535_00ID).HasColumnName("CABS_401535_00ID");
            this.Property(t => t.UniqueRecord).HasColumnName("UniqueRecord");
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
            this.Property(t => t.CSR_ACCOUNT_TOTAL).HasColumnName("CSR_ACCOUNT_TOTAL");
            this.Property(t => t.INTERSTATE_TOTAL).HasColumnName("INTERSTATE_TOTAL");
            this.Property(t => t.INTRASTATE_TOTAL).HasColumnName("INTRASTATE_TOTAL");
            this.Property(t => t.STATE_INDICATOR).HasColumnName("STATE_INDICATOR");
            this.Property(t => t.STATE_LEVEL_COMPANY_CODE).HasColumnName("STATE_LEVEL_COMPANY_CODE");
            this.Property(t => t.MPB_COMPANY_CODE).HasColumnName("MPB_COMPANY_CODE");
            this.Property(t => t.RESERVED1).HasColumnName("RESERVED1");
            this.Property(t => t.INTERSTATE_TOTAL_PAYMENT_PLAN).HasColumnName("INTERSTATE_TOTAL_PAYMENT_PLAN");
            this.Property(t => t.INTRASTATE_TOTAL_PAYMENT_PLAN).HasColumnName("INTRASTATE_TOTAL_PAYMENT_PLAN");
            this.Property(t => t.CSR_ACCOUNT_TOTAL_PAYMENT_PLAN).HasColumnName("CSR_ACCOUNT_TOTAL_PAYMENT_PLAN");
            this.Property(t => t.LOCAL_TOTAL).HasColumnName("LOCAL_TOTAL");
            this.Property(t => t.RESERVED2).HasColumnName("RESERVED2");
        }
    }
}

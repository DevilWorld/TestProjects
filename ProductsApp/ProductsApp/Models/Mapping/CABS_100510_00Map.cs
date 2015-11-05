using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_100510_00Map : EntityTypeConfiguration<CABS_100510_00>
    {
        public CABS_100510_00Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_100510_00ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_100510_00");
            this.Property(t => t.CABS_100510_00ID).HasColumnName("CABS_100510_00ID");
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
            this.Property(t => t.RESERVED1).HasColumnName("RESERVED1");
            this.Property(t => t.INVOICE_NUMBER).HasColumnName("INVOICE_NUMBER");
            this.Property(t => t.RESERVED2).HasColumnName("RESERVED2");
            this.Property(t => t.TOTAL_AMOUNT_LAST_BILL).HasColumnName("TOTAL_AMOUNT_LAST_BILL");
            this.Property(t => t.PAYMENTS_APPLIED).HasColumnName("PAYMENTS_APPLIED");
            this.Property(t => t.ADJUSTMENTS_APPLIED_TOTAL).HasColumnName("ADJUSTMENTS_APPLIED_TOTAL");
            this.Property(t => t.ADJUSTMENTS_APPLIED_INTERSTATE).HasColumnName("ADJUSTMENTS_APPLIED_INTERSTATE");
            this.Property(t => t.ADJUSTMENTS_APPLIED_INTRASTATE).HasColumnName("ADJUSTMENTS_APPLIED_INTRASTATE");
            this.Property(t => t.ADJUSTMENTS_APPLIED_NON_JURISDICTIONAL).HasColumnName("ADJUSTMENTS_APPLIED_NON_JURISDICTIONAL");
            this.Property(t => t.TOTAL_BALANCE_DUE).HasColumnName("TOTAL_BALANCE_DUE");
            this.Property(t => t.MPB_COMPANY_CODE).HasColumnName("MPB_COMPANY_CODE");
            this.Property(t => t.ADJUSTMENTS_APPLIED_LOCAL).HasColumnName("ADJUSTMENTS_APPLIED_LOCAL");
            this.Property(t => t.RESERVED3).HasColumnName("RESERVED3");
        }
    }
}

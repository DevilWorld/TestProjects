using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_102090_00Map : EntityTypeConfiguration<CABS_102090_00>
    {
        public CABS_102090_00Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_102090_00ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_102090_00");
            this.Property(t => t.CABS_102090_00ID).HasColumnName("CABS_102090_00ID");
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
            this.Property(t => t.TOTAL_CREDIT_ADJUSTMENTS).HasColumnName("TOTAL_CREDIT_ADJUSTMENTS");
            this.Property(t => t.TOTAL_DEBIT_ADJUSTMENTS).HasColumnName("TOTAL_DEBIT_ADJUSTMENTS");
            this.Property(t => t.ADJUSTMENTS_APPLIED_TOTAL).HasColumnName("ADJUSTMENTS_APPLIED_TOTAL");
            this.Property(t => t.TOTAL_OF_PENALTY_CREDIT_ADJUSTMENTS).HasColumnName("TOTAL_OF_PENALTY_CREDIT_ADJUSTMENTS");
            this.Property(t => t.TOTAL_OF_ALL_OTHER_ADJUSTMENTS).HasColumnName("TOTAL_OF_ALL_OTHER_ADJUSTMENTS");
        }
    }
}

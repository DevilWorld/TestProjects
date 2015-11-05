using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_103090_00Map : EntityTypeConfiguration<CABS_103090_00>
    {
        public CABS_103090_00Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_103090_00ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_103090_00");
            this.Property(t => t.CABS_103090_00ID).HasColumnName("CABS_103090_00ID");
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
            this.Property(t => t.TOTAL_OTHER_CHARGES_AND_CREDITS).HasColumnName("TOTAL_OTHER_CHARGES_AND_CREDITS");
            this.Property(t => t.TOTAL_OF_PENALTY_CREDIT_ADJUSTMENTS).HasColumnName("TOTAL_OF_PENALTY_CREDIT_ADJUSTMENTS");
            this.Property(t => t.TOTAL_OF_ALL_OTHER_OCCS).HasColumnName("TOTAL_OF_ALL_OTHER_OCCS");
            this.Property(t => t.TOTAL_OTHER_CHARGES_AND_CREDITSPAYMENT_PLAN).HasColumnName("TOTAL_OTHER_CHARGES_AND_CREDITSPAYMENT_PLAN");
            this.Property(t => t.TOTAL_MISSED_PERFORMANCE_CREDITS).HasColumnName("TOTAL_MISSED_PERFORMANCE_CREDITS");
        }
    }
}

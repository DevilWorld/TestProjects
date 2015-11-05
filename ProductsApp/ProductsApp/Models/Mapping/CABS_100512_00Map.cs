using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_100512_00Map : EntityTypeConfiguration<CABS_100512_00>
    {
        public CABS_100512_00Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_100512_00ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_100512_00");
            this.Property(t => t.CABS_100512_00ID).HasColumnName("CABS_100512_00ID");
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
            this.Property(t => t.LATE_PAYMENT_CHARGES_TOTAL).HasColumnName("LATE_PAYMENT_CHARGES_TOTAL");
            this.Property(t => t.LATE_PAYMENT_CHARGES_INTERSTATE).HasColumnName("LATE_PAYMENT_CHARGES_INTERSTATE");
            this.Property(t => t.LATE_PAYMENT_CHARGES_INTRASTATE).HasColumnName("LATE_PAYMENT_CHARGES_INTRASTATE");
            this.Property(t => t.MONTHLY_CHARGES_TOTAL).HasColumnName("MONTHLY_CHARGES_TOTAL");
            this.Property(t => t.MONTHLY_CHARGES_INTERSTATE).HasColumnName("MONTHLY_CHARGES_INTERSTATE");
            this.Property(t => t.MONTHLY_CHARGES_INTRASTATE).HasColumnName("MONTHLY_CHARGES_INTRASTATE");
            this.Property(t => t.LATE_PAYMENT_CHARGES_NON_DISTINCT).HasColumnName("LATE_PAYMENT_CHARGES_NON_DISTINCT");
            this.Property(t => t.MONTHLY_CHARGES_LOCAL).HasColumnName("MONTHLY_CHARGES_LOCAL");
            this.Property(t => t.LATE_PAYMENT_CHARGES_LOCAL).HasColumnName("LATE_PAYMENT_CHARGES_LOCAL");
        }
    }
}

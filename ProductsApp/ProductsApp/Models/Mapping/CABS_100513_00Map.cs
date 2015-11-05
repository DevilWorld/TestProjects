using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_100513_00Map : EntityTypeConfiguration<CABS_100513_00>
    {
        public CABS_100513_00Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_100513_00ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_100513_00");
            this.Property(t => t.CABS_100513_00ID).HasColumnName("CABS_100513_00ID");
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
            this.Property(t => t.TOTAL_OTHER_CHARGES_AND_CREDITS_INTERSTATE).HasColumnName("TOTAL_OTHER_CHARGES_AND_CREDITS_INTERSTATE");
            this.Property(t => t.TOTAL_OTHER_CHARGES_AND_CREDITS_INTRASTATE).HasColumnName("TOTAL_OTHER_CHARGES_AND_CREDITS_INTRASTATE");
            this.Property(t => t.TOTAL_OTHER_CHARGES_AND_CREDITS_NON_JURISDICTIONAL).HasColumnName("TOTAL_OTHER_CHARGES_AND_CREDITS_NON_JURISDICTIONAL");
            this.Property(t => t.TOTAL_USAGE_CHARGES).HasColumnName("TOTAL_USAGE_CHARGES");
            this.Property(t => t.TOTAL_USAGE_CHARGES_INTERSTATE).HasColumnName("TOTAL_USAGE_CHARGES_INTERSTATE");
            this.Property(t => t.TOTAL_USAGE_CHARGES_INTRASTATE).HasColumnName("TOTAL_USAGE_CHARGES_INTRASTATE");
            this.Property(t => t.TOTAL_TAXES).HasColumnName("TOTAL_TAXES");
            this.Property(t => t.TOTAL_CURRENT_CHARGES).HasColumnName("TOTAL_CURRENT_CHARGES");
            this.Property(t => t.TOTAL_AMOUNT_DUE).HasColumnName("TOTAL_AMOUNT_DUE");
            this.Property(t => t.TOTAL_SURCHARGES).HasColumnName("TOTAL_SURCHARGES");
            this.Property(t => t.TOTAL_PAYMENT_PLAN_CHARGES).HasColumnName("TOTAL_PAYMENT_PLAN_CHARGES");
        }
    }
}

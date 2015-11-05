using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProductsApp.Models.Mapping
{
    public class CABS_106005_01Map : EntityTypeConfiguration<CABS_106005_01>
    {
        public CABS_106005_01Map()
        {
            // Primary Key
            this.HasKey(t => t.CABS_106005_01ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CABS_106005_01");
            this.Property(t => t.CABS_106005_01ID).HasColumnName("CABS_106005_01ID");
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
            this.Property(t => t.CIRCUIT_CHARGE_INTERSTATE_INTRALATA).HasColumnName("CIRCUIT_CHARGE_INTERSTATE_INTRALATA");
            this.Property(t => t.CIRCUIT_CHARGE_INTRASTATE_INTRALATA).HasColumnName("CIRCUIT_CHARGE_INTRASTATE_INTRALATA");
            this.Property(t => t.CIRCUIT_CHARGE_LOCAL).HasColumnName("CIRCUIT_CHARGE_LOCAL");
        }
    }
}

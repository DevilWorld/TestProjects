using EntityTest.Models;
using System.Data.Entity.ModelConfiguration;

namespace EntityTest.Mapper
{
    class StudentAddressMap : EntityTypeConfiguration<StudentAddresses>
    {
        public StudentAddressMap()
        {
            ToTable("tblStudentAddresses");
            HasKey(k => k.StudentAddressesId);
            Property(p => p.StudentAddressesId).HasColumnName("StudentAddressId").HasColumnType("int");
            Property(p => p.StudentId).HasColumnName("StudentId").HasColumnType("int").IsRequired();
            Property(p => p.AddressId).HasColumnName("AddressId").HasColumnType("int").IsRequired();
            
        }
    }
}

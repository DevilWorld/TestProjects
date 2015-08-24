using EntityTest.Models;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;

namespace EntityTest.Mapper
{
    class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("tblStudents");
            HasKey(k => k.Id);
            Property(p => p.Id).HasColumnName("StudentId").HasColumnType("int").IsRequired();
            Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
            Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
            Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
            Property(p => p.Sex).HasColumnName("Gender").HasColumnType("varchar");
            Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime2");
        }
    }
}

using System;
using System.Data.Entity.ModelConfiguration;
using EntityTest.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityTest.Mapper
{
    class SchoolMap : EntityTypeConfiguration<School>
    {
        public SchoolMap()
        {
            ToTable("tblSchool");

            HasKey(pk => pk.SchoolId);

            Property(p => p.SchoolId).HasColumnName("SchoolId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.SchoolName).HasColumnName("SchoolName");
            Property(p => p.SchoolAddressId).HasColumnName("SchoolAddressId");
            Property(p => p.PrinciId).HasColumnName("PrincipalId");

            //Relationships
            HasRequired(p => p.Principal)               //1 to   0 or 1
                .WithRequiredDependent();

            HasOptional(a => a.SchoolAddress)
                .WithOptionalDependent(s => s.School);
        }
    }
}

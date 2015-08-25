﻿using EntityTest.Models;
using System.Data.Entity.ModelConfiguration;

namespace EntityTest.Mapper
{
    class PrincipalMap : EntityTypeConfiguration<Principal>
    {
        public PrincipalMap()
        {
            ToTable("tblPrincipal");

            //Primary Key
            HasKey(pk => pk.PrincipalId);

            //Property-column mapping
            Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
            Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
            Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
            Property(p => p.Gender).HasColumnName("Gender").HasColumnType("varchar");
            Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime");

            //Foreign key relationship
            HasRequired(f => f.Address).WithRequiredDependent(f => f.Principal);
        }
    }
}

﻿using EntityTest.Models;
using System.Data.Entity.ModelConfiguration;

namespace EntityTest.Mapper
{
    class AddressMap:EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("tblAddress");
            HasKey(k => k.Id);
            Property(p => p.Id).HasColumnName("AddressId").HasColumnType("int");
            Property(p => p.Address1).HasColumnName("Address1").HasColumnType("varchar");
            Property(p => p.Address2).HasColumnName("Address2").HasColumnType("varchar");
            Property(p => p.City).HasColumnName("City").HasColumnType("varchar");
            Property(p => p.State).HasColumnName("State").HasColumnType("varchar");
            Property(p => p.Zip).HasColumnName("Zip").HasColumnType("int");
        }
    }
}

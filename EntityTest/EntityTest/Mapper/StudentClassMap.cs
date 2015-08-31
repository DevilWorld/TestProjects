using System;
using EntityTest.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityTest.Mapper
{
    class StudentClassMap:EntityTypeConfiguration<StudentClasses>
    {
        public StudentClassMap()
        {
            ToTable("tblStudentClasses");

            HasKey(pk => pk.StudentClassId);

            Property(p => p.StudentId).HasColumnName("StudentId");
            Property(p => p.ClassId).HasColumnName("ClassId");
            Property(p => p.FromDate).HasColumnName("FromDate");
            Property(p => p.ToDate).HasColumnName("ToDate");
        }
    }
}

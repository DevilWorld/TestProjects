using System.Data.Entity;
using EntityTest.Models;
using EntityTest.Mapper;

namespace EntityTest
{
    class EntityContext : DbContext
    {
        public EntityContext()
        {
            Database.SetInitializer<EntityContext>(null);
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }        
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Principal> Principal { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Teachers> Teacher { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<StudentClasses> StudentClass { get; set; }
        public DbSet<HomeWork> HomeWork { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Configurations.Add(new StudentMap());
            modelbuilder.Configurations.Add(new AddressMap());
            modelbuilder.Configurations.Add(new ParentMap());
            modelbuilder.Configurations.Add(new PrincipalMap());
            modelbuilder.Configurations.Add(new PrincipalAddressMap());
            modelbuilder.Configurations.Add(new SchoolMap());
            modelbuilder.Configurations.Add(new TeacherMap());
            modelbuilder.Configurations.Add(new SubjectMap());
            modelbuilder.Configurations.Add(new ClassMap());
            modelbuilder.Configurations.Add(new StudentClassMap());
            modelbuilder.Configurations.Add(new HomeWorkMap());
        }
    }
}

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

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Configurations.Add(new StudentMap());
            modelbuilder.Configurations.Add(new AddressMap());
            modelbuilder.Configurations.Add(new ParentMap());
            modelbuilder.Configurations.Add(new PrincipalMap());
            modelbuilder.Configurations.Add(new PrincipalAddressMap());
        }
    }
}

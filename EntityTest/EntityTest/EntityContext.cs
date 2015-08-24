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

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {            
            modelbuilder.Configurations.Add(new StudentMap());            
            modelbuilder.Configurations.Add(new AddressMap());
        }
    }
}

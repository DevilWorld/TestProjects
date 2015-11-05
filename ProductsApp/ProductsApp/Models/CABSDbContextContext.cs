using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ProductsApp.Models.Mapping;

namespace ProductsApp.Models
{
    public partial class CABSDbContextContext : DbContext
    {
        static CABSDbContextContext()
        {
            Database.SetInitializer<CABSDbContextContext>(null);
        }

        public CABSDbContextContext()
            : base("Name=CABSDbContextContext")
        {
        }

        public DbSet<CABS_100510_00> CABS_100510_00 { get; set; }
        public DbSet<CABS_100512_00> CABS_100512_00 { get; set; }
        public DbSet<CABS_100513_00> CABS_100513_00 { get; set; }
        public DbSet<CABS_100513_01> CABS_100513_01 { get; set; }
        public DbSet<CABS_101590_00> CABS_101590_00 { get; set; }
        public DbSet<CABS_102090_00> CABS_102090_00 { get; set; }
        public DbSet<CABS_102590_00> CABS_102590_00 { get; set; }
        public DbSet<CABS_103015_00> CABS_103015_00 { get; set; }
        public DbSet<CABS_103015_01> CABS_103015_01 { get; set; }
        public DbSet<CABS_103020_00> CABS_103020_00 { get; set; }
        public DbSet<CABS_103025_00> CABS_103025_00 { get; set; }
        public DbSet<CABS_103090_00> CABS_103090_00 { get; set; }
        public DbSet<CABS_105090_00> CABS_105090_00 { get; set; }
        public DbSet<CABS_106005_00> CABS_106005_00 { get; set; }
        public DbSet<CABS_106005_01> CABS_106005_01 { get; set; }
        public DbSet<CABS_106090_00> CABS_106090_00 { get; set; }
        public DbSet<CABS_401520_00> CABS_401520_00 { get; set; }
        public DbSet<CABS_401521_00> CABS_401521_00 { get; set; }
        public DbSet<CABS_401525_00> CABS_401525_00 { get; set; }
        public DbSet<CABS_401535_00> CABS_401535_00 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CABS_100510_00Map());
            modelBuilder.Configurations.Add(new CABS_100512_00Map());
            modelBuilder.Configurations.Add(new CABS_100513_00Map());
            modelBuilder.Configurations.Add(new CABS_100513_01Map());
            modelBuilder.Configurations.Add(new CABS_101590_00Map());
            modelBuilder.Configurations.Add(new CABS_102090_00Map());
            modelBuilder.Configurations.Add(new CABS_102590_00Map());
            modelBuilder.Configurations.Add(new CABS_103015_00Map());
            modelBuilder.Configurations.Add(new CABS_103015_01Map());
            modelBuilder.Configurations.Add(new CABS_103020_00Map());
            modelBuilder.Configurations.Add(new CABS_103025_00Map());
            modelBuilder.Configurations.Add(new CABS_103090_00Map());
            modelBuilder.Configurations.Add(new CABS_105090_00Map());
            modelBuilder.Configurations.Add(new CABS_106005_00Map());
            modelBuilder.Configurations.Add(new CABS_106005_01Map());
            modelBuilder.Configurations.Add(new CABS_106090_00Map());
            modelBuilder.Configurations.Add(new CABS_401520_00Map());
            modelBuilder.Configurations.Add(new CABS_401521_00Map());
            modelBuilder.Configurations.Add(new CABS_401525_00Map());
            modelBuilder.Configurations.Add(new CABS_401535_00Map());
        }
    }
}

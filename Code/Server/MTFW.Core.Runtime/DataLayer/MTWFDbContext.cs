using System.Data.Entity;

namespace MTFW.Core.Runtime.DataLayer
{
    public class MTWFDbContext : DbContext
    {
        public MTWFDbContext() : base("AppConnectionString")
        { }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.UserGuid).ToTable("USERS")
                .Property(p => p.UserGuid)
                .HasColumnName("USERGUID");
            modelBuilder.Entity<Tenant>().HasKey(t => t.TenantGuid);

            base.OnModelCreating(modelBuilder);
        }
    }
}

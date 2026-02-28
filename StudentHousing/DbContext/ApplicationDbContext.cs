

namespace StudentHousing.DbContext
{
        public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
        {

            public DbSet<Entities.Student> Students { get; set; }
            public DbSet<Entities.Owner> Owners { get; set; }
            public DbSet<Entities.House> Houses { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
                base.OnModelCreating(modelBuilder);
            }
        }
}

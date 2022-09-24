using Microsoft.EntityFrameworkCore;

namespace AspNetCoreUseEFCore
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("user")
                .HasKey(c => c.Id);
        }
    }
}

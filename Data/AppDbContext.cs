using Microsoft.EntityFrameworkCore;

namespace Dziekanat.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Models.Users> users { get; set; } = default!;

        /* do uzupełnienia */
    }
}

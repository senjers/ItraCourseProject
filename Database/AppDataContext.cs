using Microsoft.EntityFrameworkCore;
using Itra.Models;

namespace Itra.Database
{
    public class AppDataContext : DbContext
    {
        public DbSet<Item> Items { get; set; } = null!;
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

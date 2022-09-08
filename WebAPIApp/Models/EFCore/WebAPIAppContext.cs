using Microsoft.EntityFrameworkCore;

namespace WebAPIApp.Models.EFCore
{
    public class WebAPIAppContext : DbContext
    {
        public WebAPIAppContext(DbContextOptions<WebAPIAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}

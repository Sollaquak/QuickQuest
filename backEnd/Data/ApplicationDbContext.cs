using Microsoft.EntityFrameworkCore;

namespace QuickQuest.backEnd.Data  // Ensure this matches your project
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Define your database tables here
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

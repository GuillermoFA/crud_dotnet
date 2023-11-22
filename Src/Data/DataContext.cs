using apinet.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace apinet.Src.Data
{
    public class DataContext : DbContext
    {
        // Create Tables in Database
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<SocialNetwork> SocialNetworks { get; set; } = null!;
        public DbSet<Interest> Interests { get; set; } = null!;
        public DbSet<Framework> Frameworks { get; set; } = null!;

        public DataContext(DbContextOptions options) : base(options)
        {
        }

    }
}
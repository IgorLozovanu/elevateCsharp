using ClubMembershipApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubMembershipApplication.Data
{
    public class ClubMembershipDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={AppDomain.CurrentDomain.BaseDirectory}ClubMembershipDb.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }

        // Tools -> Nuget Package Manager -> Package Manager Console
        // Execute command: Add-Migration FirstCreate -> it will create Migrations directory
        // Execute command: Update-Database
    }
}

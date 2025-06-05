using Microsoft.EntityFrameworkCore;
using AdminPanel.Models; // ✅ Use your actual project name here

namespace AdminPanel.Data // ✅ Match your folder/project namespace
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}


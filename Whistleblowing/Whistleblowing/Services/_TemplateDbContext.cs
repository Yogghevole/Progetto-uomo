using Microsoft.EntityFrameworkCore;
using Whistleblowing.Infrastructure;
using Whistleblowing.Services.Shared;

namespace Whistleblowing.Services
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext()
        {
        }

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {
            DataGenerator.InitializeUsers(this);
        }

        public DbSet<User> Users { get; set; }
    }
}

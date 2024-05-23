using AzureAppDbHosting.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureAppDbHosting.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LeadEntity> Leads { get; set; }
    }
}

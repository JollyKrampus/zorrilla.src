using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zorrilla.Admin.Data.Entities;

namespace Zorrilla.Admin.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CoronavirusDeathRecord> CoronavirusDeathRecords { get; set; }
    }
}
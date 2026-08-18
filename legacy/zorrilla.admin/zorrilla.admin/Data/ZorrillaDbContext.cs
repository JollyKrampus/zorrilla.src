using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace zorrilla.admin.Data
{
    public class ZorrillaDbContext : IdentityDbContext
    {
        public ZorrillaDbContext(DbContextOptions<ZorrillaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}
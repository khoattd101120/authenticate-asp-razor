using authenticate_asp_razor.Models;
using Microsoft.EntityFrameworkCore;

namespace authenticate_asp_razor.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<ApplicationUser>? Users { get; set; }
    }
}

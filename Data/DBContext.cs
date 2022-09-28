using Microsoft.EntityFrameworkCore;
using app.Models;

namespace app.Data
{
    public class RDIDBContext : DbContext
    {
        public RDIDBContext (DbContextOptions<RDIDBContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Star> Star { get; set; }
    }
}

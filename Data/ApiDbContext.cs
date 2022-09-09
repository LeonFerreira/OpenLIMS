using Microsoft.EntityFrameworkCore;
using OpenLims.Model;

namespace OpenLIMS.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
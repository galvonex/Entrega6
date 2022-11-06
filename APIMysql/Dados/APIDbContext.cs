using Microsoft.EntityFrameworkCore;
using APIMysql.Models;

namespace APIMysql.Dados
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}

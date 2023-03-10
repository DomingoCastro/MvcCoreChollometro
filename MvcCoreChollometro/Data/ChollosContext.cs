using Microsoft.EntityFrameworkCore;
using MvcCoreChollometro.Models;

namespace MvcCoreChollometro.Data
{
    public class ChollosContext : DbContext
    {
        public ChollosContext(DbContextOptions<ChollosContext> options) : base(options) { }
        public DbSet<Chollos> Chollos { get; set; }
    }
}

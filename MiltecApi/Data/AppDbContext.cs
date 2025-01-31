using Microsoft.EntityFrameworkCore;
using MiltecApi.Entities;

namespace MiltecApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Anuncio> Anuncios { get; set; }
    }
}

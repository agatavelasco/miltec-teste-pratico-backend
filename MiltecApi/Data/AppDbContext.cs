using Microsoft.EntityFrameworkCore;
using MiltecApi.Entities;

namespace MiltecApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Anuncio> Anuncios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Anuncio>()
                .Property(a => a.Valor)
                .HasColumnType("decimal(18,2)");
        }

    }
}

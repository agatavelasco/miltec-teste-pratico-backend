using MiltecApi.Data;
using MiltecApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace MiltecApi.Repositories.Impl
{
    public class AnuncioRepository : IAnuncioRepository
    {
        private readonly AppDbContext _context;

        public AnuncioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Anuncio>> GetAll() => await _context.Anuncios.ToListAsync();

        public async Task<Anuncio> GetById(int id) => await _context.Anuncios.FindAsync(id);

        public async Task Add(Anuncio anuncio)
        {
            _context.Anuncios.Add(anuncio);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Anuncio anuncio)
        {
            _context.Anuncios.Update(anuncio);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var anuncio = await _context.Anuncios.FindAsync(id);
            if (anuncio != null)
            {
                _context.Anuncios.Remove(anuncio);
                await _context.SaveChangesAsync();
            }
        }
    }
}

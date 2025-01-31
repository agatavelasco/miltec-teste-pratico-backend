using MiltecApi.Entities;

namespace MiltecApi.Repositories
{
    public interface IAnuncioRepository
    {
        Task<List<Anuncio>> GetAll();
        Task<Anuncio> GetById(int id);
        Task Add(Anuncio anuncio);
        Task Update(Anuncio anuncio);
        Task Delete(int id);
    }
}

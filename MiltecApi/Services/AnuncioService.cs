using MiltecApi.Entities;
using MiltecApi.Repositories;

namespace MiltecApi.Services
{
    public class AnuncioService
    {
        private readonly IAnuncioRepository _repository;

        public AnuncioService(IAnuncioRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Anuncio>> GetAll() => await _repository.GetAll();
        public async Task<Anuncio> GetById(int id) => await _repository.GetById(id);
        public async Task Add(Anuncio anuncio) => await _repository.Add(anuncio);
        public async Task Update(Anuncio anuncio) => await _repository.Update(anuncio);
        public async Task Delete(int id) => await _repository.Delete(id);
    }
}

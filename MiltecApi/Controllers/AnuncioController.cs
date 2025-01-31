using Microsoft.AspNetCore.Mvc;
using MiltecApi.Entities;
using MiltecApi.Services;

namespace MiltecApi.Controllers
{
    [Route("api/anuncios")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        private readonly AnuncioService _service;

        public AnuncioController(AnuncioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Anuncio>>> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet("hello")]
        public async Task<ActionResult<string>> GetHello()
        {
            return Ok("hello");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Anuncio>> GetById(int id)
        {
            var anuncio = await _service.GetById(id);
            if (anuncio == null) return NotFound();
            return Ok(anuncio);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Anuncio anuncio)
        {
            await _service.Add(anuncio);
            return CreatedAtAction(nameof(GetById), new { id = anuncio.Id }, anuncio);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Anuncio anuncio)
        {
            if (id != anuncio.Id) return BadRequest();
            await _service.Update(anuncio);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }

}

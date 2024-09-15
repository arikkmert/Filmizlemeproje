using Filmizlemeproje.Models;
using Filmizlemeproje.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmizlemeproje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IRepository<Film> _filmRepository;

        public FilmController(IRepository<Film> filmRepository)
        {
            _filmRepository = filmRepository;
        }

        // GET: api/film
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Film>>> GetAllFilms()
        {
            var films = await _filmRepository.GetAllAsync();
            return Ok(films);
        }

        // GET: api/film/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Film>> GetFilmById(int id)
        {
            var film = await _filmRepository.GetByIdAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            return Ok(film);
        }

        // POST: api/film
        [HttpPost]
        public async Task<ActionResult> AddFilm(Film film)
        {
            await _filmRepository.AddAsync(film);
            return CreatedAtAction(nameof(GetFilmById), new { id = film.FilmId }, film);
        }

        // PUT: api/film/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateFilm(int id, Film film)
        {
            if (id != film.FilmId)
            {
                return BadRequest();
            }

            await _filmRepository.UpdateAsync(film);
            return NoContent();
        }

        // DELETE: api/film/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFilm(int id)
        {
            var film = await _filmRepository.GetByIdAsync(id);
            if (film == null)
            {
                return NotFound();
            }

            await _filmRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}

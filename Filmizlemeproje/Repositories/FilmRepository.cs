using Filmizlemeproje.Data;
using Filmizlemeproje.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmizlemeproje.Repositories
{
    public class FilmRepository : IRepository<Film>
    {
        private readonly FilmAppDbContext _context;

        public FilmRepository(FilmAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Film>> GetAllAsync()
        {
            return await _context.Films.ToListAsync(); // Tüm filmleri getir
        }

        public async Task<Film> GetByIdAsync(int id)
        {
            return await _context.Films.FindAsync(id); // ID'ye göre film getir
        }

        public async Task AddAsync(Film entity)
        {
            await _context.Films.AddAsync(entity); // Yeni film ekle
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Film entity)
        {
            _context.Films.Update(entity); // Mevcut filmi güncelle
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var film = await _context.Films.FindAsync(id);
            if (film != null)
            {
                _context.Films.Remove(film); // Film sil
                await _context.SaveChangesAsync();
            }
        }
    }
}


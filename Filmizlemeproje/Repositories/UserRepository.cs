using Filmizlemeproje.Data;
using Filmizlemeproje.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmizlemeproje.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly FilmAppDbContext _context;

        public UserRepository(FilmAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync(); // Tüm kullanıcıları getir
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id); // ID'ye göre kullanıcı getir
        }

        public async Task AddAsync(User entity)
        {
            await _context.Users.AddAsync(entity); // Yeni kullanıcı ekle
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Users.Update(entity); // Mevcut kullanıcıyı güncelle
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user); // Kullanıcıyı sil
                await _context.SaveChangesAsync();
            }
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Filmizlemeproje.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(); // Tüm kayıtları getir
        Task<T> GetByIdAsync(int id); // ID'ye göre kayıt getir
        Task AddAsync(T entity); // Yeni kayıt ekle
        Task UpdateAsync(T entity); // Kayıt güncelle
        Task DeleteAsync(int id); // ID'ye göre kayıt sil
    }
}


using Online_Book_Store.Models;
using System.Linq.Expressions;

namespace Online_Book_Store.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        // constructor
        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }
        // Ortak CRUD metotlarını biraraya toplayacağımız class/service gibi çalışcak
        // Yani VT tarafıyla konuşacak kısım
        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}

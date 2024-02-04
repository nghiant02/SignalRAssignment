using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly PizzaStoreContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(PizzaStoreContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

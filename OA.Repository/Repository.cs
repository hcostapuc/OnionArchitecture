using Microsoft.EntityFrameworkCore;
using OA.Domain.Entities;
using OA.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private readonly DbSet<T> entities;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await entities.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
            //TODO: testar com o codigo abaixo e ver qual é mais performatico
            //return await entities.AsAsyncEnumerable();
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await entities.SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateAsync(T entity)
        {
            await context.SaveChangesAsync();
        }
    }
}

using Ecommerce.Data;
using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ecommerce.Repository
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public Repo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }
        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<T> FindMatch(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().FirstOrDefaultAsync(match);
        }
        public async Task<IEnumerable<T>> FindAllMatch(Expression<Func<T, bool>> match)
        {
            return await context.Set<T>().Where(match).ToListAsync();
        }
        public async Task<T> FindMatchInclude(Expression<Func<T, bool>> match, string[] Include=null)
        {
            IQueryable<T> obj = context.Set<T>();
            if (Include != null)
            {
                foreach (var item in Include)
                {
                    obj = obj.Include(item);
                }
            }
            return await obj.FirstOrDefaultAsync(match);
        }
        public async Task<IEnumerable<T>> FindAllMatchInclude(Expression<Func<T, bool>> match, string[] Include=null)
        {
            IQueryable<T> obj = context.Set<T>();
            if (Include != null)
            {
                foreach (var item in Include)
                {
                    obj = obj.Include(item);
                }
            }
            return await obj.Where(match).ToListAsync();
        }

        public async Task<T> Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
            return entity;
        }
        public void Delete(T entity)//need only id from entity to delete
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        
    }
}

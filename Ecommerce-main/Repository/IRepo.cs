using System.Linq.Expressions;

namespace Ecommerce.Repository
{
    public interface IRepo<T> where T : class
    {
      
        Task<T> Add(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> FindAllMatchInclude(Expression<Func<T, bool>> match, string[] Include);
        Task<T> FindMatch(Expression<Func<T, bool>> match);
        Task<IEnumerable<T>> FindAllMatch(Expression<Func<T, bool>> match);
        Task<T> FindMatchInclude(Expression<Func<T, bool>> match, string[] Include);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Update(T entity);
    }
}
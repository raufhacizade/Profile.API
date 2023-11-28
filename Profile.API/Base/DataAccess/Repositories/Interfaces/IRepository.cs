using Profile.API.Base.ViewModels;
using Profile.Base.Models.Interfaces;
using System.Linq.Expressions;

namespace Profile.API.Base.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T> where T : IBaseEntity
    {
        Task<T?> Get(int id);

        Task<T?> Get(Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task<BasePaginatedViewModel<T>> GetPaginatedList(int offset, int limit, Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        Task<int> SaveChanges();

        int GetPrimaryKeyValue(T entity);
    }
}

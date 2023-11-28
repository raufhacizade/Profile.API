using Profile.API.Base.ViewModels;
using Profile.Base.Models.Interfaces;
using System.Linq.Expressions;

namespace Profile.Base.Services.Interfaces
{
    public interface IBaseReadOnlyService<T> where T : IBaseEntity
  {
    Task<T?> Get(int id, params Expression<Func<T, object>>[] includeProperties);

    Task<IEnumerable<T>> GetList(Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties);

    Task<BasePaginatedViewModel<T>> GetPaginatedList(int offset, int limit, Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties);
  }
}

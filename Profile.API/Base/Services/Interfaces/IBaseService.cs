using Profile.Base.Models.Interfaces;

namespace Profile.Base.Services.Interfaces
{
    public interface IBaseService<T> : IBaseReadOnlyService<T> where T : IBaseEntity
    {
        Task Update(T entity);

        Task<int> Create(T entity);

        Task Delete(T entity);
    }
}

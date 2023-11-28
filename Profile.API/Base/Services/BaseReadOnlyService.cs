using Profile.API.Base.DataAccess.Repositories.Interfaces;
using Profile.API.Base.DataAccess.UnitOfWork.Interfaces;
using Profile.API.Base.ViewModels;
using Profile.Base.Models.Interfaces;
using Profile.Base.Services.Interfaces;
using Profile.Extensions;
using System.Linq.Expressions;

namespace Profile.Base.Services
{
    public class BaseReadOnlyService<TEntity, TUnitOfWork, TRepository> : IBaseReadOnlyService<TEntity> where TRepository : class, IRepository<TEntity> where TUnitOfWork : IBaseUnitOfWorkRepo where TEntity : IBaseEntity
    {
        protected readonly Guid? _correlationId;
        protected readonly TUnitOfWork _unitOfWork;
        protected readonly ILogger _logger;

        public BaseReadOnlyService(TUnitOfWork unitOfWork, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        public virtual async Task<TEntity?> Get(int id, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            _logger.DebugMethodStart(nameof(Get));

            TEntity entity = await _unitOfWork.Repository<TRepository>().Get(x => x.Id == id, includeProperties);

            _logger.DebugMethodEnd(nameof(Get));
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            _logger.DebugMethodStart(nameof(GetList));

            IEnumerable<TEntity> entities = await _unitOfWork.Repository<TRepository>().GetList(predicate, includeProperties);

            _logger.DebugMethodEnd(nameof(GetList));
            return entities;
        }

        public async Task<BasePaginatedViewModel<TEntity>> GetPaginatedList(int offset, int limit, Expression<Func<TEntity, bool>>? predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            _logger.DebugMethodStart(nameof(GetPaginatedList));

            BasePaginatedViewModel<TEntity> entities = await _unitOfWork.Repository<TRepository>().GetPaginatedList(offset, limit, predicate, includeProperties);

            _logger.DebugMethodEnd(nameof(GetPaginatedList));
            return entities;
        }
    }
}

using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Profile.API.Base.DataAccess.UnitOfWork.Interfaces;

namespace Profile.API.Base.DataAccess.UnitOfWork
{
    public class BaseUnitOfWork<TContext> : IBaseUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;

        public TContext DbContext => _context;

        private readonly IServiceProvider _serviceProvider;

        public BaseUnitOfWork(TContext context, IServiceProvider serviceProvider)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public TSrv Repository<TSrv>() where TSrv : class
        {
            var serviceImpl = _serviceProvider.GetService(typeof(TSrv)) as TSrv;
            return serviceImpl;
        }

        public async Task<int> SaveChanges()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _context.Dispose();

        }
    }
}


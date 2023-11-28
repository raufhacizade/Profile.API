using Microsoft.EntityFrameworkCore;

namespace Profile.API.Base.DataAccess.UnitOfWork.Interfaces
{
    public interface IBaseUnitOfWork<TContext> : IBaseUnitOfWorkRepo, IDisposable where TContext : DbContext
    {
        TContext DbContext { get; }
    }
}

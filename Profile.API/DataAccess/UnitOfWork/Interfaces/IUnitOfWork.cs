using Profile.API.Base.DataAccess.UnitOfWork.Interfaces;
using Profile.API.Data;
using Profile.API.DataAccess.Repositories.Interfaces;

namespace Profile.API.DataAccess.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IBaseUnitOfWork<ProfileContext>
    {
        IUserRepository UserRepository { get; }
    }
}

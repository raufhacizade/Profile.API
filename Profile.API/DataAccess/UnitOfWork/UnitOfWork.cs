using Profile.API.Base.DataAccess.UnitOfWork;
using Profile.API.Data;
using Profile.API.DataAccess.Repositories.Interfaces;
using Profile.API.DataAccess.UnitOfWork.Interfaces;

namespace Profile.API.DataAccess.UnitOfWork
{
    public class UnitOfWork : BaseUnitOfWork<ProfileContext>, IUnitOfWork
    {
        public UnitOfWork(ProfileContext context, IServiceProvider serviceProvider) : base(context, serviceProvider)
        {
        }

        public IUserRepository UserRepository => Repository<IUserRepository>();
    }
}

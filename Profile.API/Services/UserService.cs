using Profile.API.DataAccess.Repositories.Interfaces;
using Profile.API.DataAccess.UnitOfWork.Interfaces;
using Profile.API.Models;
using Profile.Base.Services;
using Profile.Services.Interfaces;

namespace Profile.API.Services
{
    public class UserService : BaseService<User, IUnitOfWork, IUserRepository>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, ILogger<UserService> logger) : base(unitOfWork, logger)
        {
        }
    }
}


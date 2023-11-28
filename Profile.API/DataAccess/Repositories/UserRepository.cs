using Profile.Base.DataAccess;
using Profile.API.DataAccess.Repositories.Interfaces;
using Profile.API.Data;
using Profile.API.Models;

namespace Profile.API.DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ProfileContext context, ILogger<UserRepository> logger) : base(context, logger)
        {
        }
    }
}

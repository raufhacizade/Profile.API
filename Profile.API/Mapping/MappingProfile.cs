using Profile.API.Base.ViewModels;
using Profile.API.Models;
using Profile.API.ViewModels;

namespace Profile.Mapping
{
  public class MappingProfile : AutoMapper.Profile
  {
    public MappingProfile()
    {
      CreateMap<User, UserModel>();
      CreateMap<UserModel, User>();
      CreateMap<UserCreateModel, User>();
      CreateMap<BasePaginatedViewModel<User>, BasePaginatedViewModel<UserModel>>();
    }
  }
}

using FluentValidation;
using Microsoft.Extensions.Caching.Memory;
using Profile.API.DataAccess.Repositories;
using Profile.API.DataAccess.Repositories.Interfaces;
using Profile.API.DataAccess.UnitOfWork;
using Profile.API.DataAccess.UnitOfWork.Interfaces;
using Profile.API.Services;
using Profile.API.Validators.User;
using Profile.API.ViewModels;
using Profile.Services.Interfaces;

namespace Profile.Configuration
{
    public static class DependencyConfig
  {
    public static void ConfigureDependencies(this IServiceCollection services)
    {
      services.AddScoped<IUnitOfWork, UnitOfWork>();
      services.AddSingleton<IMemoryCache, MemoryCache>();

      // validators
      services.AddScoped<IValidator<UserCreateModel>, UserCreateModelValidator>();
      services.AddScoped<IValidator<UserModel>, UserUpdateModelValidator>();

      // repositories
      services.AddScoped<IUserRepository, UserRepository>();

      // services
      services.AddScoped<IUserService, UserService>();
    }
  }
}

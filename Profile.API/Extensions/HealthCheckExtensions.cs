using Profile.Middlewares;

namespace Profile.Extensions
{
  static partial class HealthCheckExtensions
  {
    public static IServiceCollection AddSqlConnectionHealthCheck(this IServiceCollection services)
    {
      services.AddHealthChecks().AddCheck<SqlConnectionHealthCheck>("SQL Connection check");
      return services;
    }
  }
}

namespace Profile.API.Extensions
{
  public static class ServiceCollectionExtensions
  {
    public static string ApiCorsPolicy = "ProfileCorsPolicy";
    public static IServiceCollection AddProfileCorsPolicy(this IServiceCollection services)
    {
      var allowedOrigins = new string[] { "http://localhost:5173", "http://localhost:3000" };
      services.AddCors(options =>
      {
        options.AddPolicy(name: ApiCorsPolicy,
        builder =>
        {
          builder.WithOrigins(allowedOrigins);
          builder.AllowAnyMethod();
          builder.AllowAnyHeader();
        });
      });

      return services;
    }
  }
}

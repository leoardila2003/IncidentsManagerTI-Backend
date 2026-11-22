namespace Cors;

public static class CorsService
{
  public static IServiceCollection CorsServiceRegistration(this IServiceCollection services)
  {
    services.AddCors(options =>
    {
      options.AddPolicy("AllowAll", builder =>
      {
        builder.WithOrigins("http://localhost:3000")
          .AllowAnyMethod()
          .AllowAnyHeader()
          .AllowCredentials();
      });
    });

    return services;
  }
}
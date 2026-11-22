using Services.Genders;

namespace Services;

public static class InjectServices
{
  public static IServiceCollection AddServices(this IServiceCollection services)
  {
    services.AddTransient<IGenderService, GenderService>();

    return services;
  }
}
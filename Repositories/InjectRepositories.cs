using Repositories.Genders;

namespace Repositories;

public static class InjectRepositories
{
  public static IServiceCollection AddRepositories(this IServiceCollection services)
  {
    services.AddTransient<IGenderRepository, GenderRepository>();

    return services;
  }
}
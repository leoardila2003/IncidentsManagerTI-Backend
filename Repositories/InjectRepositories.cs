using Backend.Repositories.DocumentTypes;
using Backend.Repositories.Genders;

namespace Backend.Repositories;

public static class InjectRepositories
{
  public static IServiceCollection AddRepositories(this IServiceCollection services)
  {
    services.AddTransient<IGenderRepository, GenderRepository>();
    services.AddTransient<IDocumentTypeRepository, DocumentTypeRepository>();

    return services;
  }
}
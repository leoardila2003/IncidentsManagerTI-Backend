using Backend.Repositories.DocumentTypes;
using Backend.Repositories.Genders;
using Backend.Repositories.IncidentTypes;
using Backend.Repositories.Severities;

namespace Backend.Repositories;

public static class InjectRepositories
{
  public static IServiceCollection AddRepositories(this IServiceCollection services)
  {
    services.AddTransient<IGenderRepository, GenderRepository>();
    services.AddTransient<IDocumentTypeRepository, DocumentTypeRepository>();
    services.AddTransient<ISeverityRepository, SeverityRepository>();
    services.AddTransient<IIncidentTypeRepository, IncidentTypeRepository>();

    return services;
  }
}
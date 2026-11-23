using Backend.Services.DocumentTypes;
using Backend.Services.Genders;
using Backend.Services.IncidentTypes;
using Backend.Services.Severities;

namespace Backend.Services;

public static class InjectServices
{
  public static IServiceCollection AddServices(this IServiceCollection services)
  {
    services.AddScoped<IGenderService, GenderService>();
    services.AddScoped<IDocumentTypeService, DocumentTypeService>();
    services.AddScoped<ISeverityService, SeverityService>();
    services.AddScoped<IIncidentTypeService, IncidentTypeService>();

    return services;
  }
}
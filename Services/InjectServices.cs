using Backend.Services.DocumentTypes;
using Backend.Services.Genders;

namespace Backend.Services;

public static class InjectServices
{
  public static IServiceCollection AddServices(this IServiceCollection services)
  {
    services.AddTransient<IGenderService, GenderService>();
    services.AddTransient<IDocumentTypeService, DocumentTypeService>();

    return services;
  }
}
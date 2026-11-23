using System.Data;
using Backend.Cors;
using FluentValidation;
using Backend.Mapping;
using Microsoft.EntityFrameworkCore;
using Backend.Middlewares;
using Backend.Persistence.DapperConnection;
using Backend.Persistence.EfCoreConnection;
using Backend.Repositories;
using Scalar.AspNetCore;
using Backend.Services;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

builder.Configuration.AddEnvironmentVariables();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(options =>
{
  options.AddDocumentTransformer((document, _, _) =>
  {
    document.Info = new()
    {
      Title = "Incidents Manager TI API",
      Version = "v1",
      Description = "API para la gestión de incidentes de TI."
    };
    return Task.CompletedTask;
  });
});

// Conexiones a la db
builder.Services.AddSingleton<IDbConnectionFactory>(sp =>
{
  var configuration = sp.GetRequiredService<IConfiguration>();
  var connectionString = configuration.GetConnectionString("DefaultConnection")
    ?? Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")
    ?? throw new SyntaxErrorException("Conexión no establecida correctamente");
  return new ConnectionFactory(connectionString);
});

builder.Services.AddDbContext<ConnectionDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")
        ?? Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection")
        ?? throw new SyntaxErrorException("Conexión no establecida correctamente")));

// Repositorios
builder.Services.AddRepositories();

// Servicios
builder.Services.AddServices();

// Mapeador
builder.Services.AddAutoMapper(cfg => cfg.AddMaps(typeof(BackendProfile).Assembly));

// Validadores
builder.Services.AddValidatorsFromAssemblyContaining<Program>();

// Cors
builder.Services.CorsServiceRegistration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.WithTitle("Incidents Manager TI API");
    });
}

app.UseMiddleware<GlobalExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

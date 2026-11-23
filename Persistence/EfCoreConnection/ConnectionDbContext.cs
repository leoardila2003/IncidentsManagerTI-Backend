using Backend.Entities.DocumentType;
using Backend.Entities.Gender;
using Backend.Entities.IncidentType;
using Backend.Entities.KanbanCategory;
using Backend.Entities.Permission;
using Backend.Entities.Project;
using Backend.Entities.Role;
using Backend.Entities.Severity;
using Microsoft.EntityFrameworkCore;

namespace Backend.Persistence.EfCoreConnection;

public class ConnectionDbContext : DbContext
{
  public ConnectionDbContext(DbContextOptions<ConnectionDbContext> options) : base(options)
  {}

  protected ConnectionDbContext() {}

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    // Configuración global de las entidades
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConnectionDbContext).Assembly);
  }

  // Entidades primarias
  public DbSet<Gender> Genders { get; set; }
  public DbSet<DocumentType> DocumentTypes { get; set; }
  public DbSet<Role> Roles { get; set; }
  public DbSet<Permission> Permissions { get; set; }
  public DbSet<Severity> Severities { get; set; }
  public DbSet<IncidentType> IncidentTypes { get; set; }
  public DbSet<KanbanCategory> KanbanCategories { get; set; }
  public DbSet<Project> Projects { get; set; }
}
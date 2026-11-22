using Entities.DocumentType;
using Entities.Gender;
using Entities.IncidentType;
using Entities.KanbanCategory;
using Entities.Permission;
using Entities.Project;
using Entities.Role;
using Entities.Severity;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EfCoreConnection;

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
  public DbSet<IncidentType> IncidentType { get; set; }
  public DbSet<KanbanCategory> KanbanCategories { get; set; }
  public DbSet<Project> Projects { get; set; }
}
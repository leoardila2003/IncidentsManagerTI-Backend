using Backend.Entities.IncidentType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistence.EfCoreConnection.Configurations.IncidentTypeConfig;

public class IncidentTypeEntity : IEntityTypeConfiguration<IncidentType>
{
  public void Configure(EntityTypeBuilder<IncidentType> builder)
  {
    builder.ToTable("incident_types");

    builder.Property(x => x.Name)
      .HasMaxLength(50)
      .HasColumnName("name");
    builder.HasIndex(x => x.Name)
      .IsUnique();

    builder.Property(x => x.Description)
      .HasColumnName("description");

    builder.Property(x => x.Code)
      .HasMaxLength(5)
      .HasColumnName("code");
    builder.HasIndex(x => x.Code)
      .IsUnique();

    builder.Property(x => x.Weight)
      .HasColumnName("weight");
  }
}
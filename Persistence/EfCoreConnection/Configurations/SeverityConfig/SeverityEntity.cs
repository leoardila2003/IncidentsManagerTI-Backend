using Entities.Severity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EfCoreConnection.Configurations.SeverityConfig;

public class SeverityEntity : IEntityTypeConfiguration<Severity>
{
  public void Configure(EntityTypeBuilder<Severity> builder)
  {
    builder.ToTable("severities");

    builder.Property(x => x.Name)
      .HasMaxLength(20)
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
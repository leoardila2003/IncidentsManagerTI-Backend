using Backend.Entities.Permission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistence.EfCoreConnection.Configurations.PermissionConfig;

public class PermissionEntity : IEntityTypeConfiguration<Permission>
{
  public void Configure(EntityTypeBuilder<Permission> builder)
  {
    builder.ToTable("permissions");

    builder.Property(x => x.Name)
      .HasMaxLength(100)
      .HasColumnName("name");
    builder.HasIndex(x => x.Name)
      .IsUnique();
    
    builder.Property(x => x.Code)
      .HasMaxLength(5)
      .HasColumnName("code");
    builder.HasIndex(x => x.Code)
      .IsUnique();
  }
}
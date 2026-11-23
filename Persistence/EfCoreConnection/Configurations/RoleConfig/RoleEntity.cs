using Backend.Entities.Role;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistence.EfCoreConnection.Configurations.RoleConfig;

public class RoleEntity : IEntityTypeConfiguration<Role>
{
  public void Configure(EntityTypeBuilder<Role> builder)
  {
    builder.ToTable("roles");

    builder.Property(x => x.Name)
      .HasMaxLength(50)
      .HasColumnName("name");
    builder.HasIndex(x => x.Name)
      .IsUnique();

    builder.Property(x => x.Code)
      .HasMaxLength(5)
      .HasColumnName("code");
    builder.HasIndex(x => x.Code)
      .IsUnique();

    builder.Property(x => x.Status)
      .HasDefaultValue(true)
      .HasColumnName("status");
  }
}
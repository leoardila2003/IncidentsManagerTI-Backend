using Entities.Gender;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EfCoreConnection.Configurations.GenderConfig;

public class GenderEntity : IEntityTypeConfiguration<Gender>
{
  public void Configure(EntityTypeBuilder<Gender> builder)
  {
    builder.ToTable("genders");

    builder.Property(x => x.Name)
      .HasMaxLength(15)
      .HasColumnName("name");
    builder.HasIndex(x => x.Name)
      .IsUnique();

    builder.Property(x => x.Code)
      .HasMaxLength(3)
      .HasColumnName("code");
    builder.HasIndex(x => x.Code)
      .IsUnique();
  }
}
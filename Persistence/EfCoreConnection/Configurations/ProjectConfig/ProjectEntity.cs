using Backend.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistence.EfCoreConnection.Configurations.ProjectConfig;

public class ProjectEntity : IEntityTypeConfiguration<Project>
{
  public void Configure(EntityTypeBuilder<Project> builder)
  {
    builder.ToTable("projects");

    builder.Property(x => x.Name)
      .HasMaxLength(100)
      .HasColumnName("name");
    builder.HasIndex(x => x.Name)
      .IsUnique();

    builder.Property(x => x.Code)
      .HasMaxLength(10)
      .HasColumnName("code");
    builder.HasIndex(x => x.Code)
      .IsUnique();
    
    builder.Property(x => x.Description)
      .HasColumnName("description");

    builder.Property(x => x.Url)
      .HasColumnType("text")
      .HasColumnName("url");

    builder.Property(x => x.Status)
      .HasDefaultValue(true)
      .HasColumnName("status");

    builder.Property(x => x.CreatedAt)
      .HasColumnType("timestamp")
      .HasDefaultValueSql("now()")
      .HasColumnName("created_at");
    
    builder.Property(x => x.UpdatedAt)
      .HasColumnType("timestamp")
      .HasColumnName("updated_at");
  }
}
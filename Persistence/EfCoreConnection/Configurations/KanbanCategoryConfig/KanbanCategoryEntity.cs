using Backend.Entities.KanbanCategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistence.EfCoreConnection.Configurations.KanbanCategoryConfig;

public class KanbanCategoryEntity : IEntityTypeConfiguration<KanbanCategory>
{
  public void Configure(EntityTypeBuilder<KanbanCategory> builder)
  {
    builder.ToTable("kanban_categories");

    builder.Property(x => x.Name)
      .HasMaxLength(100)
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
using Backend.Entities.DocumentType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistence.EfCoreConnection.Configurations.DocumentTypeConfig;

public class DocumentTypeConfig : IEntityTypeConfiguration<DocumentType>
{
  public void Configure(EntityTypeBuilder<DocumentType> builder)
  {
    builder.ToTable("document_types");

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
namespace Backend.Entities.DocumentType;

public class DocumentType
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty; // Único
  public string Code { get; set; } = string.Empty; // Único
}
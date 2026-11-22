namespace Entities.KanbanCategory;

public class KanbanCategory
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty; // Único
  public string? Description { get; set; }
  public string Code { get; set; } = string.Empty; // Único
  public bool Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? UpdatedAt { get; set; }
}
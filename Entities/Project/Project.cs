namespace Backend.Entities.Project;

public class Project
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty; // Único
  public string Code { get; set; } = string.Empty; // Único
  public string? Description { get; set; }
  public string Url { get; set; } = string.Empty;
  public bool Status { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? UpdatedAt { get; set; }
}
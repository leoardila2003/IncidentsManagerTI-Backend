namespace Entities.IncidentType;

public class IncidentType
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty; // Único
  public string? Description { get; set; }
  public string Code { get; set; } = string.Empty; // Único
  public int Weight { get; set; }
}
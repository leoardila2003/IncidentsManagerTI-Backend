namespace Backend.Dtos.IncidentTypes;

public class IncidentTypeResponseDto
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string? Description { get; set; }
  public string Code { get; set; } = string.Empty;
  public int Weight { get; set; }
}
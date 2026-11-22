namespace Entities.Role;

public class Role
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty; // Único
  public string Code { get; set; } = string.Empty; // Único
  public bool Status { get; set; }
}
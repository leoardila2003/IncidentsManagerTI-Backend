namespace Entities.Permission;

public class Permission
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty; // Único
  public string Code { get; set; } = string.Empty; // Único
}
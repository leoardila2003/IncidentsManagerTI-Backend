using Backend.Entities.Severity;

namespace Backend.Repositories.Severities;

public interface ISeverityRepository
{
  Task<IEnumerable<Severity>> GetAllAsync();
  Task<Severity?> GetByIdAsync(int id);
}
using Backend.Entities.IncidentType;

namespace Backend.Repositories.IncidentTypes;

public interface IIncidentTypeRepository
{
  Task<IEnumerable<IncidentType>> GetAllAsync();
  Task<IncidentType?> GetByIdAsync(int id);
}
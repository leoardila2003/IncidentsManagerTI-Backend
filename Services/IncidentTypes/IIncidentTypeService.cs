using Backend.Dtos.IncidentTypes;

namespace Backend.Services.IncidentTypes;

public interface IIncidentTypeService
{
  Task<IEnumerable<IncidentTypeResponseDto>> GetAllAsync();
  Task<IncidentTypeResponseDto?> GetByIdAsync(int id);
}
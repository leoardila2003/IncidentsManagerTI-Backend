using Backend.Dtos.Severities;

namespace Backend.Services.Severities;

public interface ISeverityService
{
  Task<IEnumerable<SeverityResponseDto>> GetAllAsync();
  Task<SeverityResponseDto?> GetByIdAsync(int id);
}
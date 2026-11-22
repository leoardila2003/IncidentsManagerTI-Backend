using Dtos.Genders;

namespace Services.Genders;

public interface IGenderService
{
  Task<IEnumerable<GenderResponseDto>> GetAllAsync();
  Task<GenderResponseDto?> GetByIdAsync(int id);
}
using Backend.Dtos.Genders;

namespace Backend.Services.Genders;

public interface IGenderService
{
  Task<IEnumerable<GenderResponseDto>> GetAllAsync();
  Task<GenderResponseDto?> GetByIdAsync(int id);
}
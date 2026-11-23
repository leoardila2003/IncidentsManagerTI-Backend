using Backend.Entities.Gender;

namespace Backend.Repositories.Genders;

public interface IGenderRepository
{
  Task<IEnumerable<Gender>> GetAllAsync();
  Task<Gender?> GetByIdAsync(int id);
}
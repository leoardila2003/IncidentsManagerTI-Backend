using Entities.Gender;

namespace Repositories.Genders;

public interface IGenderRepository
{
  Task<IEnumerable<Gender>> GetAllAsync();
  Task<Gender?> GetByIdAsync(int id);
}
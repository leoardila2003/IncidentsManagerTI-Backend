using Backend.Entities.Gender;
using Microsoft.EntityFrameworkCore;
using Backend.Persistence.EfCoreConnection;

namespace Backend.Repositories.Genders;

public class GenderRepository(ConnectionDbContext dbContext) : IGenderRepository
{
  private readonly ConnectionDbContext _dbContext = dbContext;

  public async Task<IEnumerable<Gender>> GetAllAsync()
  {
    return await _dbContext.Genders.ToListAsync();
  }

  public async Task<Gender?> GetByIdAsync(int id)
  {
    var gender = await _dbContext.Genders.FirstOrDefaultAsync(x => x.Id == id);
    if (gender is null) return null;

    return gender;
  }
}
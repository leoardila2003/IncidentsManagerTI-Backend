using Entities.Gender;
using Microsoft.EntityFrameworkCore;
using Persistence.EfCoreConnection;

namespace Repositories.Genders;

public class GenderRepository : IGenderRepository
{
  private readonly ConnectionDbContext _dbContext;

  public GenderRepository(ConnectionDbContext dbContext)
  {
    _dbContext = dbContext;
  }

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
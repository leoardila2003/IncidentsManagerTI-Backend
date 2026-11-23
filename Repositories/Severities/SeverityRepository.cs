using Backend.Entities.Severity;
using Backend.Persistence.EfCoreConnection;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories.Severities;

public class SeverityRepository(ConnectionDbContext dbContext) : ISeverityRepository
{
  private readonly ConnectionDbContext _dbContext = dbContext;

  public async Task<IEnumerable<Severity>> GetAllAsync()
  {
    return await _dbContext.Severities.ToListAsync();
  }

  public async Task<Severity?> GetByIdAsync(int id)
  {
    var severity = await _dbContext.Severities.FirstOrDefaultAsync(x => x.Id == id);
    if (severity is null) return null;

    return severity;
  }
}
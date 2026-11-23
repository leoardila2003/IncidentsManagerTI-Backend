using Backend.Entities.IncidentType;
using Backend.Persistence.EfCoreConnection;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories.IncidentTypes;

public class IncidentTypeRepository(ConnectionDbContext dbContext) : IIncidentTypeRepository
{
  private readonly ConnectionDbContext _dbContext = dbContext;

  public async Task<IEnumerable<IncidentType>> GetAllAsync()
  {
    return await _dbContext.IncidentTypes.ToListAsync();
  }

  public async Task<IncidentType?> GetByIdAsync(int id)
  {
    var incidentType = await _dbContext.IncidentTypes.FirstOrDefaultAsync(x => x.Id == id);
    if (incidentType is null) return null;

    return incidentType;
  }
}
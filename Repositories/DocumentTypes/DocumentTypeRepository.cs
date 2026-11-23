using Backend.Entities.DocumentType;
using Backend.Persistence.EfCoreConnection;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories.DocumentTypes;

public class DocumentTypeRepository(ConnectionDbContext dbContext) : IDocumentTypeRepository
{
  private readonly ConnectionDbContext _dbContext = dbContext;

  public async Task<IEnumerable<DocumentType>> GetAllAsync()
  {
    return await _dbContext.DocumentTypes.ToListAsync();
  }

  public async Task<DocumentType?> GetByIdAsync(int id)
  {
    var documentType = await _dbContext.DocumentTypes.FirstOrDefaultAsync(x => x.Id == id);
    if (documentType is null) return null;

    return documentType;
  }
}
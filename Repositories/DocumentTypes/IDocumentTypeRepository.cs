using Backend.Entities.DocumentType;

namespace Backend.Repositories.DocumentTypes;

public interface IDocumentTypeRepository
{
  Task<IEnumerable<DocumentType>> GetAllAsync();
  Task<DocumentType?> GetByIdAsync(int id);
}

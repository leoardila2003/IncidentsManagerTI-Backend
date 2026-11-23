using Backend.Dtos.DocumentTypes;

namespace Backend.Services.DocumentTypes;

public interface IDocumentTypeService
{
  Task<IEnumerable<DocumentTypeResponseDto>> GetAllAsync();
  Task<DocumentTypeResponseDto?> GetByIdAsync(int id);
}
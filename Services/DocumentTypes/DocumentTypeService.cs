using AutoMapper;
using Backend.Dtos.DocumentTypes;
using Backend.Exceptions;
using Backend.Repositories.DocumentTypes;

namespace Backend.Services.DocumentTypes;

public class DocumentTypeService(IDocumentTypeRepository documentTypeRepository, IMapper mapper) : IDocumentTypeService
{
  private readonly IDocumentTypeRepository _documentTypeRepository = documentTypeRepository;
  private readonly IMapper _mapper = mapper;

  public async Task<IEnumerable<DocumentTypeResponseDto>> GetAllAsync()
  {
    var documentTypes = await _documentTypeRepository.GetAllAsync();
    return _mapper.Map<IEnumerable<DocumentTypeResponseDto>>(documentTypes);
  }

  public async Task<DocumentTypeResponseDto?> GetByIdAsync(int id)
  {
    var documentType = await _documentTypeRepository.GetByIdAsync(id) 
      ?? throw new NotFoundException("Tipo de documento no encontrado");
    
    return _mapper.Map<DocumentTypeResponseDto>(documentType);
  }
}
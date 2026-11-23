using AutoMapper;
using Backend.Dtos.IncidentTypes;
using Backend.Exceptions;
using Backend.Repositories.IncidentTypes;

namespace Backend.Services.IncidentTypes;

public class IncidentTypeService(IIncidentTypeRepository incidentTypeRepository, IMapper mapper) : IIncidentTypeService
{
  private readonly IIncidentTypeRepository _incidentTypeRepository = incidentTypeRepository;
  private readonly IMapper _mapper = mapper;

  public async Task<IEnumerable<IncidentTypeResponseDto>> GetAllAsync()
  {
    var incidentTypes = await _incidentTypeRepository.GetAllAsync();
    return _mapper.Map<IEnumerable<IncidentTypeResponseDto>>(incidentTypes);
  }

  public async Task<IncidentTypeResponseDto?> GetByIdAsync(int id)
  {
    var incidentType = await _incidentTypeRepository.GetByIdAsync(id)
      ?? throw new NotFoundException("Tipo de incidente no encontrado");
    
    return _mapper.Map<IncidentTypeResponseDto>(incidentType);
  }
}
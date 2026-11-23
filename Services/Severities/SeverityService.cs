using AutoMapper;
using Backend.Dtos.Severities;
using Backend.Exceptions;
using Backend.Repositories.Severities;

namespace Backend.Services.Severities;

public class SeverityService(ISeverityRepository severityRepository, IMapper mapper) : ISeverityService
{
  private readonly ISeverityRepository _severityRepository = severityRepository;
  private readonly IMapper _mapper = mapper;

  public async Task<IEnumerable<SeverityResponseDto>> GetAllAsync()
  {
    var severities = await _severityRepository.GetAllAsync();
    return _mapper.Map<IEnumerable<SeverityResponseDto>>(severities);
  }

  public async Task<SeverityResponseDto?> GetByIdAsync(int id)
  {
    var severity = await _severityRepository.GetByIdAsync(id)
      ?? throw new NotFoundException("Severidad no encontrada");

    return _mapper.Map<SeverityResponseDto>(severity);
  }
}
using AutoMapper;
using Backend.Dtos.Genders;
using Backend.Exceptions;
using Backend.Repositories.Genders;

namespace Backend.Services.Genders;

public class GenderService(IGenderRepository genderRepository, IMapper mapper) : IGenderService
{
  private readonly IGenderRepository _genderRepository = genderRepository;
  private readonly IMapper _mapper = mapper;

  public async Task<IEnumerable<GenderResponseDto>> GetAllAsync()
  {
    var genders = await _genderRepository.GetAllAsync();
    return _mapper.Map<IEnumerable<GenderResponseDto>>(genders);
  }

  public async Task<GenderResponseDto?> GetByIdAsync(int id)
  {
    var gender = await _genderRepository.GetByIdAsync(id) 
      ?? throw new NotFoundException("Género no encontrado");
    
    return _mapper.Map<GenderResponseDto>(gender);
  }
}

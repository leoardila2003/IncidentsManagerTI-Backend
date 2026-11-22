using Dtos.Genders;
using Exceptions;
using Mapping;
using Repositories.Genders;

namespace Services.Genders;

public class GenderService : IGenderService
{
  private readonly IGenderRepository _genderRepository;
  private readonly BackendProfile _mapper;

  public GenderService(IGenderRepository genderRepository, BackendProfile mapper)
  {
    _genderRepository = genderRepository;
    _mapper = mapper;
  }

  public async Task<IEnumerable<GenderResponseDto>> GetAllAsync()
  {
    var genders = await _genderRepository.GetAllAsync();
    return _mapper.ToDto(genders);
  }

  public async Task<GenderResponseDto?> GetByIdAsync(int id)
  {
    var gender = await _genderRepository.GetByIdAsync(id) ?? throw new NotFoundException("Género no encontrado");
    return _mapper.ToDto(gender);
  }
}
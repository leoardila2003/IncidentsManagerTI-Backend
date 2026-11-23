using AutoMapper;
using Backend.Dtos.Genders;
using Backend.Entities.Gender;

namespace Backend.Mapping;

public class BackendProfile : Profile
{
  public BackendProfile()
  {
    // Géneros
    CreateMap<Gender, GenderResponseDto>();
  }
}

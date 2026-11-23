using AutoMapper;
using Backend.Dtos.DocumentTypes;
using Backend.Dtos.Genders;
using Backend.Entities.DocumentType;
using Backend.Entities.Gender;

namespace Backend.Mapping;

public class BackendProfile : Profile
{
  public BackendProfile()
  {
    // Géneros
    CreateMap<Gender, GenderResponseDto>().ReverseMap();
    // Tipos de documentos
    CreateMap<DocumentType, DocumentTypeResponseDto>().ReverseMap();
  }
}

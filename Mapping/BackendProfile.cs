using AutoMapper;
using Backend.Dtos.DocumentTypes;
using Backend.Dtos.Genders;
using Backend.Dtos.Severities;
using Backend.Entities.DocumentType;
using Backend.Entities.Gender;
using Backend.Entities.Severity;

namespace Backend.Mapping;

public class BackendProfile : Profile
{
  public BackendProfile()
  {
    // Géneros
    CreateMap<Gender, GenderResponseDto>().ReverseMap();
    // Tipos de documentos
    CreateMap<DocumentType, DocumentTypeResponseDto>().ReverseMap();
    // Severidades
    CreateMap<Severity, SeverityResponseDto>().ReverseMap();
  }
}

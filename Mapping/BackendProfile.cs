using Dtos.Genders;
using Entities.Gender;
using Riok.Mapperly.Abstractions;

namespace Mapping;

[Mapper]
public partial class BackendProfile
{
  // Géneros
  public partial GenderResponseDto ToDto(Gender entity);
  public partial IEnumerable<GenderResponseDto> ToDto(IEnumerable<Gender> entities);
}
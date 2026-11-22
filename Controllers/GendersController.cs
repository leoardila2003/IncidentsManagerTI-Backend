using Microsoft.AspNetCore.Mvc;
using Services.Genders;

namespace Controllers;

public class GendersController : BaseControllerCustom
{
  private readonly IGenderService _genderService;

  public GendersController(IGenderService genderService)
  {
    _genderService = genderService;
  }

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var genders = await _genderService.GetAllAsync();
    return OkResponse(genders);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetById(int id)
  {
    var gender = await _genderService.GetByIdAsync(id);
    return OkResponse(gender);
  }
}
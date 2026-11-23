using Backend.Services.IncidentTypes;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

public class IncidentTypesController(IIncidentTypeService incidentTypeService) : BaseControllerCustom
{
  private readonly IIncidentTypeService _incidentTypeService = incidentTypeService;

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var incidentTypes = await _incidentTypeService.GetAllAsync();
    return OkResponse(incidentTypes);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetByIdAsync(int id)
  {
    var incidentType = await _incidentTypeService.GetByIdAsync(id);
    return OkResponse(incidentType);
  }
}
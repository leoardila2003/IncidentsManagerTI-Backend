using Backend.Services.Severities;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

public class SeveritiesController(ISeverityService severityService) : BaseControllerCustom
{
  private readonly ISeverityService _severityService = severityService;

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var severities = await _severityService.GetAllAsync();
    return OkResponse(severities);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetById(int id)
  {
    var severity = await _severityService.GetByIdAsync(id);
    return OkResponse(severity);
  }
}
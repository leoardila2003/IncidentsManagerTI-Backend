using Backend.Services.DocumentTypes;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

public class DocumentTypesController(IDocumentTypeService documentTypeService) : BaseControllerCustom
{
  private readonly IDocumentTypeService _documentTypeService = documentTypeService;

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var documentTypes = await _documentTypeService.GetAllAsync();
    return OkResponse(documentTypes);
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> GetById(int id)
  {
    var documentType = await _documentTypeService.GetByIdAsync(id);
    return OkResponse(documentType);
  }
}
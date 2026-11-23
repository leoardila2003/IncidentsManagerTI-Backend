using Microsoft.AspNetCore.Mvc;
using Backend.Responses;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseControllerCustom : ControllerBase
{
  protected IActionResult OkResponse<T>(T data, string message = "Operación completada", int statusCode = 200)
    {
        var response = new CustomApiResponses<T>
        {
            Success = true,
            StatusCode = statusCode,
            Message = message,
            Path = HttpContext?.Request?.Path ?? string.Empty,
            ResponseTime = DateTime.UtcNow,
            Items = data
        };

        return StatusCode(statusCode, response);
    }

    // respuesta base para Created genérica
    protected IActionResult CreatedResponse<T>(T data, string? message = null, int statusCode = 201)
    {
        var finalMessage = string.IsNullOrWhiteSpace(message) ? "Recurso creado" : message;
        var response = new CustomApiResponses<T>
        {
            Success = true,
            StatusCode = statusCode,
            Message = finalMessage,
            Path = HttpContext?.Request?.Path ?? string.Empty,
            ResponseTime = DateTime.UtcNow,
            Items = data
        };

        return StatusCode(statusCode, response);
    }
}
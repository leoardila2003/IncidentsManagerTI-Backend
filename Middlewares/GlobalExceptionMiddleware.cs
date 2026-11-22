using System.Text.Json;
using Exceptions;
using Responses;

namespace Middlewares;

public class GlobalExceptionMiddleware
{
  private readonly RequestDelegate _next;
  private readonly ILogger<GlobalExceptionMiddleware> _logger;

  public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
  {
    _next = next;
    _logger = logger;
  }

  public async Task Invoke(HttpContext context)
  {
    var originalBodyStream = context.Response.Body;

    try
    {
      await _next(context);
    }
    catch (Exception ex)
    {
      var response = context.Response;
      response.ContentType = "application/json";
      response.Body = originalBodyStream;

      var apiResponse = new CustomApiResponses<object>
      {
        Success = false,
        Path = context.Request.Path,
        ResponseTime = DateTime.UtcNow,
        Items = null
      };

      switch (ex)
      {
        case NotFoundException:
          response.StatusCode = apiResponse.StatusCode = StatusCodes.Status404NotFound;
          apiResponse.Message = ex.Message;
          break;

        case UnauthorizedException:
          response.StatusCode = apiResponse.StatusCode = StatusCodes.Status401Unauthorized;
          apiResponse.Message = ex.Message;
          break;

        case BadRequestException:
          response.StatusCode = apiResponse.StatusCode = StatusCodes.Status400BadRequest;
          apiResponse.Message = ex.Message;
          break;

        case ForbiddenException:
          response.StatusCode = apiResponse.StatusCode = StatusCodes.Status403Forbidden;
          apiResponse.Message = ex.Message;
          break;

        case ConflictException:
          response.StatusCode = apiResponse.StatusCode = StatusCodes.Status409Conflict;
          apiResponse.Message = ex.Message;
          break;

        case DatabaseOperationException:
          response.StatusCode = apiResponse.StatusCode = StatusCodes.Status503ServiceUnavailable;
          apiResponse.Message = ex.Message;
          break;

        default:
          response.StatusCode = apiResponse.StatusCode = StatusCodes.Status500InternalServerError;
          apiResponse.Message = "An unexpected error ocurred";
          _logger.LogError(ex, "Error no controlled");
          break;
      }

      var result = JsonSerializer.Serialize(apiResponse);
      await response.WriteAsync(result);
    }
  }
}
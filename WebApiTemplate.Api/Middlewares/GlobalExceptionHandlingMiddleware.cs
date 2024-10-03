using System.Net;
using System.Text.Json;
using WebApiProject.Core.Exceptions;

public class GlobalExceptionHandlingMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        var statusCode = GetStatusCode(ex);
        context.Response.StatusCode = (int)statusCode;
        context.Response.ContentType = "application/json";

        var errorResponse = new ErrorResponse
        {
            StatusCode = statusCode,
            Message = ex.Message
        };

        var json = JsonSerializer.Serialize(errorResponse);
        await context.Response.WriteAsync(json);
    }

    private static HttpStatusCode GetStatusCode(Exception ex)
    {
        return ex switch
        {
            NotFoundException => HttpStatusCode.NotFound,
            BadRequestException => HttpStatusCode.BadRequest,
            _ => HttpStatusCode.InternalServerError
        };
    }
}

/// <summary>
/// For demonstration only
/// </summary>
public class ErrorResponse
{
    public HttpStatusCode StatusCode { get; set; }
    public string Message { get; set; } = null!;
}
public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, List<string> errors) : base(message)
    {
        Errors = errors;
    }

    public List<string> Errors { get; }
}

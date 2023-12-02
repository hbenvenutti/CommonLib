using Microsoft.AspNetCore.Http;

namespace Benvenutti.Lib.Middlewares;

public interface IExceptionHandler
{
    public Task InvokeAsync(HttpContext httpContext);
}

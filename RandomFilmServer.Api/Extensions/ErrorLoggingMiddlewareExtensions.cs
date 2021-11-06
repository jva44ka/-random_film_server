namespace RandomFilmServer.Api.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Middlewares;

    public static class ErrorLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
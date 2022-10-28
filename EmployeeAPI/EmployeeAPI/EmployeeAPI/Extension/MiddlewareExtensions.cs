using EmployeeAPI.Middleware;

namespace EmployeeAPI.Extension
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestLogger(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<RequestLoggerMiddleware>();
        }

    }
}

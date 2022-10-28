using EmployeeAPI.Model;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace EmployeeAPI.Middleware
{
    public static class ExceptionHandlerMiddleware
    {
        public static void UseGlobalExceptionHandler(this IApplicationBuilder app, ILogger logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        var errorDetails = new ErrorDetails();
                        errorDetails.StatusCode = context.Response.StatusCode;
                        errorDetails.Message = "Internal Server Error UseGlobalExceptionHandler.";

                        if (errorDetails != null)
                        {
                            await context.Response.WriteAsJsonAsync<ErrorDetails>(errorDetails);
                        }
                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                    }
                });
            });
        }
    }
}

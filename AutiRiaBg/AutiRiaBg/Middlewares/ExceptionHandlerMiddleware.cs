namespace AutiRiaBg.Middlewares
{
    using AutoRiaBg.Application.Exceptions;
    using Microsoft.AspNetCore.Http;
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Threading.Tasks;
    

    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private const string ResponseContentType = "application/json";

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ApplicationExceptionBase a_ex)
            {
                await HandleExceptionAsync(context, a_ex);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, ApplicationExceptionBase exception)
        {
            context.Response.ContentType = ResponseContentType;

            switch (exception)
            {
                default:
                    break;
            }
            // to do finish;
            return null;
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = ResponseContentType;
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return context.Response.WriteAsync(JsonConvert.SerializeObject(new { error = exception.Message }));
        }
    }
}

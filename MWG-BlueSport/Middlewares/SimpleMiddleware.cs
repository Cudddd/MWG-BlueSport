using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MWG_BlueSport.Middlewares
{
    public class SimpleMiddleware
    {
        private readonly RequestDelegate _next;
        
        public SimpleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.Headers.Add("Simple-Middleware", "1");
            await _next(context);
        }
    }
}
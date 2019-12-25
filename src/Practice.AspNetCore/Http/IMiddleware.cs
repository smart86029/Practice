using System.Threading.Tasks;

namespace Practice.AspNetCore.Http
{
    public interface IMiddleware
    {
        Task InvokeAsync(HttpContext context, RequestDelegate next);
    }
}
using System.Threading.Tasks;

namespace Practice.AspNetCore.Http
{
    public delegate Task RequestDelegate(HttpContext context);
}
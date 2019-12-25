using System.Threading.Tasks;
using Practice.AspNetCore.Http;

namespace Practice.AspNetCore.Hosting
{
    public interface IServer
    {
        Task StartAsync(RequestDelegate handler);
    }
}
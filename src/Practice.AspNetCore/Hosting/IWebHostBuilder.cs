using System;
using Practice.AspNetCore.Http;

namespace Practice.AspNetCore.Hosting
{
    public interface IWebHostBuilder
    {
        IWebHostBuilder UseServer(IServer server);

        IWebHostBuilder Configure(Action<IApplicationBuilder> configure);

        IWebHost Build();
    }
}
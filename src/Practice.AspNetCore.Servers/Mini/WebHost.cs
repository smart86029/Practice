using System.Threading.Tasks;
using Practice.AspNetCore.Hosting;
using Practice.AspNetCore.Http;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class WebHost : IWebHost
    {
        private readonly IServer server;
        private readonly RequestDelegate handler;

        public WebHost(IServer server, RequestDelegate handler)
        {
            this.server = server;
            this.handler = handler;
        }

        public void Start()
        {
            StartAsync().GetAwaiter().GetResult();
        }

        public async Task StartAsync()
        {
            await server.StartAsync(handler);
        }
    }
}
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Practice.AspNetCore.Hosting;
using Practice.AspNetCore.Http;
using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class Server : IServer
    {
        private readonly HttpListener httpListener = new HttpListener();
        private readonly string[] urls;

        public Server(params string[] urls)
        {
            this.urls = urls.Any() ? urls : new string[] { "http://localhost:5000/" };
        }

        public async Task StartAsync(RequestDelegate handler)
        {
            foreach (var url in urls)
                httpListener.Prefixes.Add(url);

            httpListener.Start();
            while (true)
            {
                var listenerContext = await httpListener.GetContextAsync();
                var features = new FeatureCollection();
                features.Set<IHttpRequestFeature>(new RequestFeature(listenerContext));
                features.Set<IHttpResponseFeature>(new ResponseFeature(listenerContext));

                var httpContext = new MiniHttpContext(features);
                await handler(httpContext);

                listenerContext.Response.Close();
            }
        }
    }
}
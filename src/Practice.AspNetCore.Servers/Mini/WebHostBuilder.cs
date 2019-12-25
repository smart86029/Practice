using System;
using System.Collections.Generic;
using Practice.AspNetCore.Hosting;
using Practice.AspNetCore.Http;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class WebHostBuilder : IWebHostBuilder
    {
        private readonly List<Action<IApplicationBuilder>> configures = new List<Action<IApplicationBuilder>>();

        private IServer server;

        public IWebHostBuilder Configure(Action<IApplicationBuilder> configure)
        {
            configures.Add(configure);

            return this;
        }

        public IWebHostBuilder UseServer(IServer server)
        {
            this.server = server;

            return this;
        }

        public IWebHost Build()
        {
            var builder = new ApplicationBuilder();
            foreach (var configure in configures)
                configure(builder);

            return new WebHost(server, builder.Build());
        }
    }
}
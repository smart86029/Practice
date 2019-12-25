using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.AspNetCore.Http;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class ApplicationBuilder : IApplicationBuilder
    {
        private readonly IList<Func<RequestDelegate, RequestDelegate>> middlewares = new List<Func<RequestDelegate, RequestDelegate>>();

        public IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware)
        {
            middlewares.Add(middleware);

            return this;
        }

        public RequestDelegate Build()
        {
            RequestDelegate app = context =>
            {
                context.Response.StatusCode = 404;
                return Task.CompletedTask;
            };

            foreach (var middleware in middlewares.Reverse())
                app = middleware(app);

            return app;
        }
    }
}
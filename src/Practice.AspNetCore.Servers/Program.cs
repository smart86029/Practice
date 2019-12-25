using System;
using Practice.AspNetCore.Hosting;
using Practice.AspNetCore.Http;
using Practice.AspNetCore.Servers.Mini;

namespace Practice.AspNetCore.Servers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Start();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            new WebHostBuilder()
                .UseServer(new Server())
                .Configure(app =>
                {
                    app.Use(OneMiddleware);
                    app.Use(TwoMiddleware);
                });

        public static RequestDelegate OneMiddleware(RequestDelegate next)
        {
            Console.WriteLine("1");
            return async context =>
            {
                Console.WriteLine("1 返回");
                await context.Response.WriteAsync("1=>");
                await next(context);
            };
        }

        public static RequestDelegate TwoMiddleware(RequestDelegate next)
        {
            Console.WriteLine("2");
            return async context =>
            {
                Console.WriteLine("2 返回");
                await context.Response.WriteAsync("2=>");
                await next(context);
            };
        }
    }
}
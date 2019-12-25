using System.Collections.Specialized;
using System.IO;
using System.Net;
using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class ResponseFeature : IHttpResponseFeature
    {
        private readonly HttpListenerContext context;

        public ResponseFeature(HttpListenerContext context)
        {
            this.context = context;
        }

        public int StatusCode
        {
            get => context.Response.StatusCode;
            set => context.Response.StatusCode = value;
        }

        public NameValueCollection Headers => context.Response.Headers;

        public Stream Body => context.Response.OutputStream;
    }
}
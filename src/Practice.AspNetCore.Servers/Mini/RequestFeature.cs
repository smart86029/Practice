using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class RequestFeature : IHttpRequestFeature
    {
        private readonly HttpListenerContext context;

        public RequestFeature(HttpListenerContext context)
        {
            this.context = context;
        }

        public Uri Url => context.Request.Url;

        public NameValueCollection Headers => context.Request.Headers;

        public Stream Body => context.Request.InputStream;
    }
}
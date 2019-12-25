using System;
using System.Collections.Specialized;
using System.IO;

namespace Practice.AspNetCore.Http
{
    public abstract class HttpRequest
    {
        public abstract Uri Url { get; }

        public abstract NameValueCollection Headers { get; }

        public abstract Stream Body { get; }
    }
}
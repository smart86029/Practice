using System;
using System.Collections.Specialized;
using System.IO;
using Practice.AspNetCore.Http;
using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Servers.Mini
{
    internal sealed class MiniHttpRequest : HttpRequest
    {
        private readonly IHttpRequestFeature feature;

        public MiniHttpRequest(IFeatureCollection features)
        {
            feature = features.Get<IHttpRequestFeature>();
        }

        public override Uri Url => feature.Url;

        public override NameValueCollection Headers => feature.Headers;

        public override Stream Body => feature.Body;
    }
}
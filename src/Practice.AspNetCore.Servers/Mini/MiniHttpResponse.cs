using System.Collections.Specialized;
using System.IO;
using Practice.AspNetCore.Http;
using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Servers.Mini
{
    internal sealed class MiniHttpResponse : HttpResponse
    {
        private readonly IHttpResponseFeature feature;

        public MiniHttpResponse(IFeatureCollection features)
        {
            feature = features.Get<IHttpResponseFeature>();
        }

        public override int StatusCode
        {
            get => feature.StatusCode;
            set => feature.StatusCode = value;
        }

        public override NameValueCollection Headers => feature.Headers;

        public override Stream Body => feature.Body;
    }
}
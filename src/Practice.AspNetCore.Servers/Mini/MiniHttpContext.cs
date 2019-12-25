using Practice.AspNetCore.Http;
using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Servers.Mini
{
    internal class MiniHttpContext : HttpContext
    {
        private readonly IFeatureCollection features;
        private readonly MiniHttpRequest request;
        private readonly MiniHttpResponse response;

        public MiniHttpContext(IFeatureCollection features)
        {
            this.features = features;
            request = new MiniHttpRequest(features);
            response = new MiniHttpResponse(features);
        }

        public override IFeatureCollection Features => features;

        public override HttpRequest Request => request;

        public override HttpResponse Response => response;
    }
}
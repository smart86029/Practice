using Practice.AspNetCore.Http.Features;

namespace Practice.AspNetCore.Http
{
    public abstract class HttpContext
    {
        public abstract IFeatureCollection Features { get; }

        public abstract HttpRequest Request { get; }

        public abstract HttpResponse Response { get; }
    }
}
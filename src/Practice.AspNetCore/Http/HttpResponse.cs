using System.Collections.Specialized;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Practice.AspNetCore.Http
{
    public abstract class HttpResponse
    {
        public abstract int StatusCode { get; set; }

        public abstract NameValueCollection Headers { get; }

        public abstract Stream Body { get; }

        public Task WriteAsync(string contents)
        {
            var buffer = Encoding.UTF8.GetBytes(contents);

            return Body.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}
using System.Threading.Tasks;

namespace Practice.AspNetCore.Hosting
{
    public interface IWebHost
    {
        void Start();

        Task StartAsync();
    }
}
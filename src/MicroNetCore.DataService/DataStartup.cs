using Microsoft.Extensions.Configuration;

namespace MicroNetCore.DataService
{
    public abstract class DataStartup : Startup
    {
        protected DataStartup(IConfiguration configuration)
            : base(configuration)
        {
        }
    }
}
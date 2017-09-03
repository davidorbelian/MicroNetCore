using Microsoft.Extensions.Configuration;

namespace MicroNetCore.BusinessService
{
    public abstract class BusinessStartup : Startup
    {
        protected BusinessStartup(IConfiguration configuration)
            : base(configuration)
        {
        }
    }
}
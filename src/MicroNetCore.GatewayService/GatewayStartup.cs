using MicroNetCore.AspNetCore.Proxy.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroNetCore.GatewayService
{
    public abstract class GatewayStartup : Startup
    {
        protected GatewayStartup(IConfiguration configuration)
            : base(configuration)
        {
        }

        protected override IServiceCollection GetServices()
        {
            return new ServiceCollection()
                .AddProxy(Configuration);
        }
    }
}
using Microsoft.AspNetCore.Hosting;

namespace MicroNetCore.GatewayService
{
    public abstract class GatewayProgram : Program<GatewayStartup>
    {
        protected static IWebHost BuildGateway(string[] args)
        {
            return BuildHost(args);
        }
    }
}
using MicroNetCore.AspNetCore.Proxy.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MicroNetCore.GatewayService
{
    public sealed class GatewayStartup : Startup
    {
        public GatewayStartup(IConfiguration configuration)
            : base(configuration)
        {
        }

        protected override void Add(IServiceCollection services)
        {
            services.AddProxy(Configuration);
        }

        protected override void Use(IApplicationBuilder app)
        {
            app.UseProxy();
        }
    }
}
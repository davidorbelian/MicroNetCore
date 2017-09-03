using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MicroNetCore
{
    public abstract class Startup
    {
        protected readonly IConfiguration Configuration;

        protected Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected abstract IServiceCollection GetServices();

        public void ConfigureServices(IServiceCollection services)
        {
            foreach (var service in GetServices())
                services.Add(service);
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
        }
    }
}
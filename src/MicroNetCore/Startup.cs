using System;
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

        protected abstract void Add(IServiceCollection services);
        protected abstract void Use(IApplicationBuilder app);

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            Add(services);

            return services.BuildServiceProvider();
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            Use(app);
        }
    }
}
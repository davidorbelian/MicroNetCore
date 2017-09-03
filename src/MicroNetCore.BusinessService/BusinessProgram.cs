using Microsoft.AspNetCore.Hosting;

namespace MicroNetCore.BusinessService
{
    public abstract class BusinessProgram : Program<BusinessStartup>
    {
        protected static IWebHost BuildBusiness(string[] args)
        {
            return BuildHost(args);
        }
    }
}
using Microsoft.AspNetCore.Hosting;

namespace MicroNetCore.DataService
{
    public abstract class DataProgram : Program<DataStartup>
    {
        protected static IWebHost BuildData(string[] args)
        {
            return BuildHost(args);
        }
    }
}
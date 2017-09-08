using MicroNetCore.GatewayService;
using Microsoft.AspNetCore.Hosting;

namespace MicroNetCore.SampleGateway
{
    public sealed class SampleGatewayProgram : GatewayProgram
    {
        public static void Main(string[] args)
        {
            BuildGateway(args).Run();
        }
    }
}
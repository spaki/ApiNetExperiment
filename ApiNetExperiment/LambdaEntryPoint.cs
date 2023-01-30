using Amazon.Lambda.AspNetCoreServer;

namespace ApiNetExperiment
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder) => builder.UseStartup<Startup>();

        protected override void Init(IHostBuilder builder) {}
    }
}

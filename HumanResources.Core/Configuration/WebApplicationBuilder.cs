using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace HumanResources.Core.Configuration
{
    public static class WebApplicationBuilder
    {
        public static IHostBuilder ConfigureAppSettings(this IHostBuilder hostBuilder)
        {   
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var test = AppContext.BaseDirectory;
            
            hostBuilder.ConfigureAppConfiguration((hostContext, builder) =>
            {
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json", false, true);
                builder.AddJsonFile($"appsettings.{environment}.json", true, true);
                builder.AddEnvironmentVariables();
            });

            return hostBuilder;
        }
    }
}

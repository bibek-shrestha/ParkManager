using System;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace ParkManager.Infrastructure.Config;

public static class LoggerConfiguration
{
    public static IHostBuilder ConfigureSerilog(this IHostBuilder host)
    {
        host.UseSerilog((context, configuration) =>
            configuration.ReadFrom.Configuration(context.Configuration));
        return host;
    }
}

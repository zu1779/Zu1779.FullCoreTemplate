namespace Zu1779.FCT.Presentation.RPGWebMVC
{
    using System;

    using LightInject.Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Logging;
    using NLog.Web;

    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                logger.Debug("init main");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseLightInject()
                .UseStartup<Startup>()
                .ConfigureLogging(c =>
                {
                    c.ClearProviders();
                    c.SetMinimumLevel(LogLevel.Trace);
                })
                .UseNLog(new NLogAspNetCoreOptions());
    }
}

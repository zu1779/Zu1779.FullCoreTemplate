namespace Zu1779.FCT.Service.MainServiceAPI
{
    using LightInject;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddControllersAsServices();
        }

        public void ConfigureContainer(IServiceContainer container)
        {
            container.RegisterFrom<CompositionRoot>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var rootPath = env.ContentRootPath;
            app.UseErrorHandlingMiddleware();
            app.UseMvc(c =>
            {
                c.MapRoute(name: "api", template: "api/{controller}/{action}/{id?}");
            });
        }
    }
}

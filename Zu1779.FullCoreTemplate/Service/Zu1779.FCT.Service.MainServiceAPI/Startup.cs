namespace Zu1779.FCT.Service.MainServiceAPI
{
    using LightInject;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.DependencyInjection;
    using Swashbuckle.AspNetCore.Swagger;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddControllersAsServices()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Main Service API", Version = "v1" });
            });
        }

        public void ConfigureContainer(IServiceContainer container)
        {
            container.RegisterFrom<CompositionRoot>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var rootPath = env.ContentRootPath;
            app.UseErrorHandlingMiddleware();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MainServiceAPI V1"));
            app.UseMvc(c =>
            {
                c.MapRoute(name: "api", template: "api/{controller}/{action}/{id?}");
            });
        }
    }
}

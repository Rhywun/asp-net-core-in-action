using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AddingMvcToEmptyProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => { options.MaxModelValidationErrors = 100; });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default",
                                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

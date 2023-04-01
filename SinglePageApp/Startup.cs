using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SinglePageApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseFileServer();
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using zorrilla.admin.Areas.Identity;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]

namespace zorrilla.admin.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}
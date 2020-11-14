using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAuth.Areas.Identity.Data;

[assembly: HostingStartup(typeof(WebAuth.Areas.Identity.IdentityHostingStartup))]
namespace WebAuth.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebAuthIdentityDbContext>(options =>
                    options.UseNpgsql(
                        context.Configuration.GetConnectionString("WebAuthIdentityDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebAuthIdentityDbContext>();
            });
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using NordiskLuksusMVC.Models;


namespace NordiskLuksusMVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddDbContext<MatContext>(
                options => options.UseSqlite("Data Source=NordiskLuksusMVC.db")
            );
            services.AddSession(
                options =>
                {
                    options.IdleTimeout = TimeSpan.FromMinutes(5);
                }
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(
                routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Nordisk}/{action=Welcome}/{id?}"
                    );
                }
            );
        }
    }
}

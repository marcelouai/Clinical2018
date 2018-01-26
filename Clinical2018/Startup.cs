using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Clinical2018.Data;
using Microsoft.EntityFrameworkCore;
using Clinical2018.Models;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace Clinical2018
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IFileProvider>(
                    new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));

            services.AddDbContext<Clinical2018Contexto>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();

            services.AddDbContext<Clinical2018Context>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Clinical2018Context")));

            //services.AddDbContext<Clinical2019Context>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("Clinical2019Context")));

            //services.AddDbContext<Clinical2018Context>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("Clinical2018Context")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Pessoa/Teste");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

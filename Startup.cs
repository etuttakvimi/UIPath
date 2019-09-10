using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Serialization;
using UIPath.Models;

namespace UIPath
{
    public class Startup
    {

        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConntection")));
            services.AddTransient<IStudentRepository, EFStudentRepository>();
            services.AddTransient<ICodeRepository, EFCodeRepository>();
            services.AddTransient<IUIpathStudentRepository, EFUIpathStudentRepository>();
            services.AddMvc().AddJsonOptions(options =>
                 {
                     options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                 }); ;
            services.AddDirectoryBrowser();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseStaticFiles(); // wwwroot
            // app.UseStaticFiles(new StaticFileOptions
            // {
            //     FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
            //     RequestPath = "/Content"
            // });

            app.UseDirectoryBrowser(new DirectoryBrowserOptions
            {
                FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img")),
                RequestPath = "/img"
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();
            app.UseMvc(routes =>
                  {
                      routes.MapRoute(
                          name: "default",
                          template: "{controller=Home}/{action=Index}/{id?}"
                      );
                  });

            // SeedData.Seed(app);
        }
    }
}

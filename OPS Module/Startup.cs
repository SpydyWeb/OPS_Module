using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.DBClass;
using Microsoft.AspNetCore.Identity;
using DataLayer.Query;
using DataLayer.TableClass;

namespace OPS_Module
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
            services.AddControllersWithViews();           
            services.AddDbContext<DBContext>(op=>op.UseSqlServer(this.Configuration.GetConnectionString("OPSModuleConnection")));
            //services.AddDbContext<DBContext>(op=>op.UseSqlServer(this.Configuration.GetConnectionString("sameerconnection")));
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddIdentity<OPS_Mst_Employee, IdentityRole>(p => {
                p.Password.RequireDigit = true;
                p.Password.RequiredLength = 6;
                p.Password.RequireLowercase = true;
                p.Password.RequireUppercase = true;
                p.User.RequireUniqueEmail = true;
                });
           // services.AddScoped<IAuthenticationQuery, AuthenticationQuery>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

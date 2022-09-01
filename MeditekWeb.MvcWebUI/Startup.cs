using MeditekWeb.Business.Abstract;
using MeditekWeb.Business.Concrete;
using MeditekWeb.DataAccess.Abstract;
using MeditekWeb.DataAccess.Concrete;
using MeditekWeb.DataAccess.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeditekWeb.MvcWebUI
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
            services.AddSingleton<IManagerBs, ManagerBs>();
            services.AddSingleton<IManagerRepository, ManagerRepository>();
            services.AddSingleton<ITeamBs, TeamBs>();
            services.AddSingleton<ITeamRepository, TeamRepository>();
            services.AddSingleton<IEventBs, EventBs>();
            services.AddSingleton<IEventRepository, EventRepository>();
            services.AddSingleton<IUnitBs, UnitBs>();
            services.AddSingleton<IUnitRepository, UnitRepository>();
            services.AddSingleton<IMemberBs, MemberBs>();
            services.AddSingleton<IMemberRepository, MemberRepository>();
            services.AddSingleton<IContactBs, ContactBs>();
            services.AddSingleton<IContactRepository, ContactRepository>();





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
                endpoints.MapAreaControllerRoute(
                    name: "adminContact",
                    areaName: "AdminPanel",
                    pattern: "admin-contact",
                    defaults: new { controller = "Contact", action = "Index" }
                    );
                endpoints.MapAreaControllerRoute(
                    name:"adminLogin",
                    areaName:"AdminPanel",
                    pattern:"admin",
                    defaults: new { controller = "Manager", action = "Login" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminDashBoard",
                    areaName: "AdminPanel",
                    pattern: "admin-dashboard",
                    defaults: new { controller = "DashBoard", action = "Index" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminEvent",
                    areaName: "AdminPanel",
                    pattern: "admin-event",
                    defaults: new { controller = "Event", action = "Index" }
                    );
                
                endpoints.MapAreaControllerRoute(
                    name: "adminNewEvent",
                    areaName: "AdminPanel",
                    pattern: "new-event",
                    defaults: new { controller = "Event", action = "New" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminEventPhotoUpload",
                    areaName: "AdminPanel",
                    pattern: "event-photo-upload",
                    defaults: new { controller = "Event", action = "PhotoUpload" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminUnit",
                    areaName: "AdminPanel",
                    pattern: "admin-unit",
                    defaults: new { controller = "Unit", action = "Index" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminNewUnit",
                    areaName: "AdminPanel",
                    pattern: "new-unit",
                    defaults: new { controller = "Unit", action = "New" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminUnitPhotoUpload",
                    areaName: "AdminPanel",
                    pattern: "unit-photo-upload",
                    defaults: new { controller = "Unit", action = "PhotoUpload" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminMember",
                    areaName: "AdminPanel",
                    pattern: "admin-member",
                    defaults: new { controller = "Member", action = "Index" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminNewMember",
                    areaName: "AdminPanel",
                    pattern: "new-member",
                    defaults: new { controller = "Member", action = "New" }
                    );
                endpoints.MapAreaControllerRoute(
                    name: "adminPhotoUpload",
                    areaName: "AdminPanel",
                    pattern: "member-photo-upload",
                    defaults: new { controller = "Member", action = "PhotoUpload" }
                    );
                


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
            });
        }
    }
}

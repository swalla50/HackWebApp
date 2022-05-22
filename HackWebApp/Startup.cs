using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using Swashbuckle;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace HackWebApp
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HackWebApp", Version = "v1" });
            });
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            services.AddDbContext<GetHierarchyContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("getHierarchy")));
            services.AddDbContext<GetOptionTypeContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("getOptionType")));
            services.AddDbContext<CompanyContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("CompanyList")));
            services.AddDbContext<GetBuildingRemindersContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BuildingReminders")));
            services.AddDbContext<GetCompanyRemindersContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("CompanyReminders")));
            services.AddDbContext<GetAllRemindersContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("AllReminders")));
            services.AddDbContext<GetBuildingsContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("AllBuildings")));
            services.AddDbContext<GetBuildingandHierarchyContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BuildingandHierarchy")));
            services.AddDbContext<GetContactsContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Contacts")));
            services.AddDbContext<DeleteReminderContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DeleteReminder")));
            services.AddDbContext<GetLeaseRemindersContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("LeaseReminders")));
            services.AddDbContext<AddReminderContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("AddReminder")));
        }
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        app.UseCors(builder => builder.WithOrigins("http://localhost:4200", "https://costarhackathon22.netlify.app").AllowAnyHeader().AllowAnyMethod().AllowCredentials().Build());

        app.Use(async (ctx, next) =>
        {
            await next();
            if (ctx.Response.StatusCode == 204)
            {
                ctx.Response.ContentLength = 0;
            }
        });


        if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HackWebApp v1"));
            }

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore.Design;
using TaskManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Core.RepositoryInterfaces;
using TaskManagement.Infrastructure.Repositories;
using TaskManagement.Core.Entities;
using TaskManagement.Core.ServiceInterfaces;
using TaskManagement.Infrastructure.Services;

namespace TaskManagement.API
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TaskManagement.API", Version = "v1" });
            });

            //add DbContext
            services.AddDbContext<TaskManagementDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(("TaskManagementDbConnection"))));

            services.AddScoped<IAsyncRepository<Core.Entities.Task>, EfRepository<Core.Entities.Task>>();
            services.AddScoped<IAsyncRepository<TaskHistory>, EfRepository<TaskHistory>>();
            services.AddScoped<IAsyncRepository<User>, EfRepository<User>>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IUserService, UserService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskManagement.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

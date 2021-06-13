using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API
{    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {          _config= config;        }
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<DataContext>(options =>
            {                options.UseSqlite(_config.GetConnectionString("DefaultConnection"));            });

/*
            var conn = "Server = LAPTOP-8DMLOOD0\\SQLEXPRESS2016; Database = A---EFcfDbGenVSCode22; Trusted_Connection = True; ";
            services.AddDbContext<DataContext>(o => o.UseSqlServer(conn));*/
            services.AddCors(); 
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(corsPolicy=>corsPolicy
            .AllowAnyHeader()
            .AllowAnyMethod()
            .WithOrigins("https://localhost:4200"));
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>  {     endpoints.MapControllers();  });
        }
    }
}

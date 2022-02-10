using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Data;
using DbPractices.DataAccess.Dapper.Abstract;
using DbPractices.DataAccess.Dapper.Concrete;
using DbPractices.DataAccess.EntityFramework.Abstract;
using DbPractices.DataAccess.EntityFramework.Concrete;
using DbPractices.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DbPractices
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DbPractices", Version = "v1" });
            });
            string dbConnectionString = Configuration.GetConnectionString("default");

            var context=  services.AddDbContext<SchoolDbContext>(options => 
                options.UseSqlServer(dbConnectionString));

            services.AddScoped<IDbConnection>(sp => new SqlConnection(dbConnectionString));

            services.AddScoped<IEfStudentDal, EfStudentDal>();
            services.AddScoped<IDpStudentDal, DpStudentDal>();
            services.AddScoped<IDpGradeDal, DpGradeGal>();
            services.AddScoped<IEfGradeDal, EfGradeDal>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DbPractices v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

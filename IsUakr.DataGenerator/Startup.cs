using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace IsUakr.DataGenerator
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
            var builder = new PostgreSqlConnectionStringBuilder(
                "dfqjg178fisif3",
                "ec2-176-34-184-174.eu-west-1.compute.amazonaws.com",
                "d21ed0472a9f90c3ed1a987d81fab642d98fb0efe9de3afd6a855f9948030a1b",
                "bmtvsxirwexwqf",
                5432, 
                true, 
                true, 
                SslMode.Require);
            //services.AddTransient(o => new NpgDbContext(builder.ConnectionString));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
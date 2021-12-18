using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace EatWell.API
{
    using Persistence;
    using Services;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EatWellContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("EatWellDatabase")));

            services.AddTransient<IProductRepository, ProductRepository>()
                    .AddTransient<IProductService, ProductService>();

            services.AddControllers()
                .ConfigureApiBehaviorOptions(x => x.SuppressMapClientErrors = true);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EatWell.Web", Version = "v1" });
            });

            services.AddMediatR(typeof(Startup));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, EatWellContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                //Dangerous action! Use only on development enviroments!
                db.Database.EnsureCreated();
            }

            app.UseSwagger()
               .UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EatWell.Web v1"));

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
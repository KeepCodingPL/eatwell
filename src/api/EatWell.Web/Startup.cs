using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace EatWell.API
{
    using EatWell.API.Utils.Security.Encryption;
    using EatWell.API.Utils.Security.JWT;
    using Microsoft.IdentityModel.Tokens;
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
            var tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = tokenOptions.Issuer,
                        ValidAudience = tokenOptions.Audience,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
                    };
                });
            services.AddTransient<IProductRepository, ProductRepository>()
                    .AddTransient<IUserRepository, UserRepository>()
                    .AddTransient<IProductService, ProductService>()
                    .AddTransient<IUserService,UserService>()
                    .AddTransient<ITokenHelper, JwtHelper>();

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

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
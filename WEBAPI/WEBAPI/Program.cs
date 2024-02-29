using DataAccess.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NLog;
using NLog.Web;
using Services.Helping;
using System.Text;

namespace WEBAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
            Console.OutputEncoding = Encoding.UTF8;
            logger.Info("init main");

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                // Add services to the container.

                builder.Services.AddControllers();

                builder.Logging.ClearProviders();
                builder.Host.UseNLog();

                // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen(opt =>
                {
                    opt.AddSecurityDefinition("Bearer", new()
                    {
                        In = ParameterLocation.Header,
                        Description = "Please enter a valid token",
                        Name = "Authorization",
                        Type = SecuritySchemeType.Http,
                        BearerFormat = "JWT",
                        Scheme = "Bearer"
                    });
                    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                    {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        new string[]{}
                    }
                    });

                });
                builder.Services.AddDbContext<BizlabbgIcanContext>();

                // Register services from service layer
                builder.Services.AddServiceLayerInternalServices();
                builder.Services.AddServiceLayerAuthServices(builder.Configuration);
                builder.Services.AddServiceLayerShippingServices();
                builder.Services.AddHelperServices();

                string jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
                string jwtKey = builder.Configuration.GetSection("Jwt:Key").Get<string>();

                builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtIssuer,
                        ValidAudience = jwtIssuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
                    };
                });

                builder.Services.AddAuthorization();

                var app = builder.Build();

                using (var scope = app.Services.CreateScope())
                {
                    var service = scope.ServiceProvider.GetService<IDBSeedingService>();
                    service.SeedDatabase();
                    service.ConvertForeignTableOrdersToNativeTableOrders();
                }

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                //app.UseAuthentication();
                app.UseAuthorization();


                app.MapControllers();

                app.Run();
            } 
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
            finally
            {
                LogManager.Shutdown();
            }
        }
    }
}
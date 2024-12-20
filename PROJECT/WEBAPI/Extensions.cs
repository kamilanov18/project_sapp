﻿using DataAccess.Data;
using Services.Auth;
using Services.Helping;
using Services.Internal;
using Services.Shipping;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Principal;

namespace WEBAPI
{
    public static class Extensions
    {
        private static List<Type> GetInterfaces(Assembly assembly)
        {
            List<Type> interfaces = new();
            foreach (Type t in assembly.ExportedTypes)
            {
                if(t.IsInterface)
                    interfaces.Add(t);
            }
            return interfaces;
        }
        public static IServiceCollection AddServiceLayerInternalServices(this IServiceCollection services)
        {
            Assembly serviceAssembly = Assembly.GetAssembly(typeof(StatusService));
            var interfaces = GetInterfaces(serviceAssembly);
            foreach( var type in serviceAssembly.ExportedTypes)
            {
                if (type.Namespace != "Services.Internal" || type.IsInterface || type.IsValueType) continue;
                var foundInterfaces = type.FindInterfaces((i,interfaces) => i.Name == "I" + type.Name,interfaces);
                if( foundInterfaces != null && foundInterfaces.Length>0) 
                {
                    Type interfaceType = foundInterfaces.First();
                    services.AddTransient(interfaceType, type);
                }
            }
            return services;
        }

        public static IServiceCollection AddServiceLayerAuthServices(this IServiceCollection services, ConfigurationManager config)
        {
            services.AddScoped<IAuthService, AuthService>(x =>new AuthService(
                x.GetService<BizlabbgIcanContext>(),
                config.GetSection("Jwt:Issuer").Get<string>(),
                config.GetSection("Jwt:Key").Get<string>())
            );
            return services;
        }

        public static IServiceCollection AddServiceLayerShippingServices(this IServiceCollection services)
        {
            services.AddScoped<IShippingService, EcontShippingService>(x=>new EcontShippingService(x.GetService<BizlabbgIcanContext>()));
            services.AddScoped<IShippingService, SpeedyShippingService>();
            services.AddSingleton<ShippingServiceResolver>(opt=>new ShippingServiceResolver(services));

            return services;
        }

        public static IServiceCollection AddHelperServices(this IServiceCollection services)
        {
            services.AddScoped<IDBSeedingService, DBSeedingService>(x=> 
                new DBSeedingService(
                    x.GetService<BizlabbgIcanContext>(), 
                    x.GetService<IAuthService>(),
                    x.GetService<ShippingServiceResolver>())
            );
            services.AddScoped<INomenclatureService, NomenclatureService>(x =>
            new NomenclatureService(
                x.GetService<BizlabbgIcanContext>(),
                x.GetService<ShippingServiceResolver>())
            );
            return services;
        }

        public static int GetId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirstValue("userId")??"-1");
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System.Reflection.Metadata.Ecma335;

namespace Services.Shipping
{
    public class ShippingServiceResolver
    {
        private IServiceCollection _services;
        public ShippingServiceResolver(IServiceCollection services)
        {
            _services = services;
        }
        public IShippingService Resolve(string key) => key switch
        {
            "econt" => _services.BuildServiceProvider().GetService<EcontShippingService>(),
            "speedy" => _services.BuildServiceProvider().GetService<SpeedyShippingService>(),
            _ => throw new KeyNotFoundException()
        };
    }
}

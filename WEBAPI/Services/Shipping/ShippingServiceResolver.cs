using Microsoft.Extensions.DependencyInjection;

namespace Services.Shipping
{
    public class ShippingServiceResolver
    {
        private IServiceCollection _services;
        public ShippingServiceResolver(IServiceCollection services)
        {
            _services = services;
        }
        public IShippingService Resolve(string key)
        {
            switch (key)
            {
                case "econt":
                    return _services.BuildServiceProvider().GetService<EcontShippingService>();
                case "speedy":
                    return _services.BuildServiceProvider().GetService<SpeedyShippingService>();
                default:
                    throw new KeyNotFoundException();
            }
        }
    }
}

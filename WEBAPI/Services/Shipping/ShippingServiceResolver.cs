using Microsoft.Extensions.DependencyInjection;
using Org.BouncyCastle.Asn1.X509.Qualified;
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
            "econt" => _services.BuildServiceProvider().GetServices<IShippingService>().Where(x => x is EcontShippingService).First(),
            "speedy" => _services.BuildServiceProvider().GetServices<IShippingService>().Where(x => x is SpeedyShippingService).First(),
            _ => throw new KeyNotFoundException()
        };
    }
}

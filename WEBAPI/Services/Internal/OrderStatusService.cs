using Microsoft.Extensions.Logging;

namespace Services.Internal
{
    public class OrderStatusService: IOrderStatusService
    {
        ILogger<OrderStatusService> _logger;
        public OrderStatusService(ILogger<OrderStatusService> logger)
        {
            _logger = logger;
            _logger.LogInformation("Instantiate OrderStatusService");
        }
    }
}

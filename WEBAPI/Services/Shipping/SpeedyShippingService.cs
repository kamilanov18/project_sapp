using Models.DTOs.Shipping;

namespace Services.Shipping
{
    public class SpeedyShippingService : IShippingService
    {
        public string GenerateWaybill(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<OrderTrackingDTO> GetTrackingDetails(int orderId)
        {
            throw new NotImplementedException();
        }

        public void SendShipment(ShippingDetails shippingDetails)
        {
            throw new NotImplementedException();
        }
    }
}

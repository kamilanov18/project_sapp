using Models.DTOs.Shipping;

namespace Services.Shipping
{
    public interface IShippingService
    {
        public string GenerateWaybill(int orderId);
        public Task<HttpResponseMessage> SendShipmentAsync(ShippingDetails shippingDetails);
        //public List<OrderTrackingDTO> GetTrackingDetails(int orderId);

    }
}

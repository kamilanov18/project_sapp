using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text.Json;

namespace Services.Shipping
{
    public class EcontShippingService : IShippingService
    {
        private static readonly string _url = "https://demo.econt.com/ee/services/";
        public string GenerateWaybill(int orderId)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> SendShipmentAsync(ShippingDetails shippingDetails)
        {
            var client = new HttpClient();
            var res = await client.SendAsync(new()
            {
                Method = new("POST"),
                RequestUri = new(_url+ "Shipments/LabelService.createLabel.json"),
                Content = JsonContent.Create(shippingDetails)
            });
            return res;
        }

        public string GenerateShipmentJSON(ShippingDetails shippingDetails)
        {
            return JsonSerializer.Serialize<EcontShipmentDTO>(shippingDetails as EcontShipmentDTO);

        }
    }
}

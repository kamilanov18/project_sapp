using Microsoft.AspNetCore.Http;
using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;
using System.Buffers.Text;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text.Json;
using System.Text.Json.Serialization;

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
            var content = new StringContent(JsonSerializer.Serialize(
                (EcontShipmentDTO)shippingDetails,options: new() { PropertyNamingPolicy=JsonNamingPolicy.CamelCase})
            );
            HttpRequestMessage msg = new()
            {
                Method = new("POST"),
                RequestUri = new(_url + "Shipments/LabelService.createLabel.json"),
                Content = content,
            };
            content.CopyTo(Console.OpenStandardOutput(),null, new());
            var test = (await content.ReadFromJsonAsync<EcontShipmentDTO>());
            Console.WriteLine(test);
            msg.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("iasp-dev:1Asp-dev"))}");
            var res = await client.SendAsync(msg);
            return res;
        }

        public async Task<HttpResponseMessage> ValidateAddress(AddressDTO dto)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(
                dto, options: new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })
            );
            HttpRequestMessage msg = new()
            {
                Method = new("POST"),
                RequestUri = new(_url + "Nomenclatures/AddressService.validateAddress.json"),
                Content = content,
            };
            content.CopyTo(Console.OpenStandardOutput(), null, new());
            var test = (await content.ReadFromJsonAsync<EcontShipmentDTO>());
            Console.WriteLine(test);
            msg.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("iasp-dev:1Asp-dev"))}");
            var res = await client.SendAsync(msg);
            return res;
        }

        public string GenerateShipmentJSON(ShippingDetails shippingDetails)
        {
            return JsonSerializer.Serialize<EcontShipmentDTO>(shippingDetails as EcontShipmentDTO);

        }
    }
}

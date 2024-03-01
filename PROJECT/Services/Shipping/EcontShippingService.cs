﻿using Microsoft.AspNetCore.Http;
using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;
using System.Net.Http.Json;
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

        public async Task<HttpResponseMessage> ValidateAddress(ShippingAddressDTO dto)
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

        public async Task<List<CountryDTO>> EcontGetCountries()
        {
            var client = new HttpClient();
            HttpRequestMessage msg = new()
            {
                Method = new("GET"),
                RequestUri = new(_url + "Nomenclatures/NomenclaturesService.getCountries.json"),
            };
            msg.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("iasp-dev:1Asp-dev"))}");
            var res = await client.SendAsync(msg);
            
            Console.WriteLine(await res.Content.ReadAsStringAsync());
            return JsonSerializer.Deserialize<GetCountriesResponseDTO>(await res.Content.ReadAsStringAsync(), 
                options: new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }
            ).Countries;
        }

        public async Task<List<CityDTO>> EcontGetCities(string countryCode)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(
                new { CountryCode = countryCode }, options: new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })
            );
            HttpRequestMessage msg = new()
            {
                Method = new("POST"),
                RequestUri = new(_url + "Nomenclatures/NomenclaturesService.getCities.json"),
                Content = content,
            };
            content.CopyTo(Console.OpenStandardOutput(), null, new());
            var test = (await content.ReadFromJsonAsync<GetCitiesResponseDTO>());
            Console.WriteLine(test);
            msg.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("iasp-dev:1Asp-dev"))}");
            var res = await client.SendAsync(msg);
            Console.WriteLine(await res.Content.ReadAsStringAsync());
            return JsonSerializer.Deserialize<GetCitiesResponseDTO>(await res.Content.ReadAsStringAsync(),
                options: new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }
            ).Cities;
        }

        public async Task<List<StreetDTO>> EcontGetStreets(string cityId)
        {
            var client = new HttpClient();
            var content = new StringContent(JsonSerializer.Serialize(
                new { cityID = cityId })
            );
            HttpRequestMessage msg = new()
            {
                Method = new("POST"),
                RequestUri = new(_url + "Nomenclatures/NomenclaturesService.getStreets.json"),
                Content = content,
            };
            content.CopyTo(Console.OpenStandardOutput(), null, new());
            var test = (await content.ReadFromJsonAsync<GetStreetsResponseDTO>());
            Console.WriteLine(test);
            msg.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("iasp-dev:1Asp-dev"))}");
            var res = await client.SendAsync(msg);
            Console.WriteLine(await res.Content.ReadAsStringAsync());
            return JsonSerializer.Deserialize<GetStreetsResponseDTO>(await res.Content.ReadAsStringAsync(),
                options: new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }
            ).Streets;
        }

        public Task<List<QuarterDTO>> EcontGetQuarters(int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
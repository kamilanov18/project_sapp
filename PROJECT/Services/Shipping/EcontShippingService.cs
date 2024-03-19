using DataAccess.Data;
using Microsoft.AspNetCore.Http;
using Models.DTOs.Shipping;
using Models.DTOs.Shipping.Econt;
using System.Net.Http.Json;
using System.Text.Json;

namespace Services.Shipping
{
    public class EcontShippingService : IEcontShippingService
    {
        private static readonly string _url = "https://demo.econt.com/ee/services/";
        BizlabbgIcanContext _ctx;
        public EcontShippingService(BizlabbgIcanContext contex)
        {
            _ctx = contex;
        }
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

        public async Task<List<CountryDTO>> GetCountries()
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

        public async Task<List<CityDTO>> GetCities(string countryCode)
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

        public async Task<List<StreetDTO>> GetStreets(string cityId)
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

        public Task<List<QuarterDTO>> GetQuarters(int cityId)
        {
            throw new NotImplementedException();
        }

        public ClientDTO GetSenderClient()
        {
            return (from c in _ctx.IcaksSappEcontClients
                    select new ClientDTO()
                    {
                        Name = c.Name,
                        Phones = (from p in _ctx.IcaksSappEcontPhones
                                  where p.ClientId == c.Id
                                  select p.Phone).ToList(),
                    }).Take(1).First();
        }

        public AddressDTO GetSenderAddress()
        {
            return (from a in _ctx.IcaksSappEcontAddresses
                    select new AddressDTO
                    {
                        City = (from c in _ctx.IcaksSappEcontCities
                                where c.Id == a.CityId
                                select new CityDTO
                                {
                                    Country = (from cr in _ctx.IcaksSappEcontCountries
                                               where cr.Code3 == c.CountryCode
                                               select new CountryDTO
                                               {
                                                   Code2 = cr.Code2,
                                                   Code3 = cr.Code3,
                                                    Name=cr.Name 
                                               }).Take(1).First(),
                                    Id = c.Id,
                                    PostCode=c.PostCode,
                                    Name=c.Name,
                                }).First(),
                        Num=a.Num, 
                        Id=a.Id,
                        FullAddress=a.FullAddress,
                        Quarter=a.Quarter,
                        Street=a.Street,
                        Other=a.Other
                    }).Take(1).First();
        }
    }
}

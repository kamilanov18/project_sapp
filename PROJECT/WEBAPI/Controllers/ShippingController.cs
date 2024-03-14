using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Internal.Orders;
using Models.DTOs.Shipping.Econt;
using Services.Shipping;
using System.Text.Json;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        ILogger<ShippingController> _logger;
        IShippingService _econtService, _speedyService;
        public ShippingController(ILogger<ShippingController> logger, ShippingServiceResolver resolver)
        {
            _econtService = resolver.Resolve("econt");
            _speedyService = resolver.Resolve("speedy");
            _logger = logger;
        }

        [Authorize(Roles = "admin, caller")]
        [HttpPost]
        public async Task<IActionResult> ShipToEcont(OrderDetailsDTO dto)
        {
            EcontShipmentDTO shipment = new();
            try
            {
                shipment.Mode = "create";
                shipment.Label.ReceiverAddress = (AddressDTO)dto.Address;
                shipment.Label.Weight = dto.Products.Sum(x => x.Count);

                var res = await _econtService.SendShipmentAsync(shipment);
                res.Content.ReadAsStream().CopyTo(Console.OpenStandardOutput());
                _logger.LogInformation($"User with id: {User.GetId()} sent econt shipment to: {shipment.Label.ReceiverClient.Name}");
                return Ok();
            } 
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried sending econt shipment to: {shipment.Label.ReceiverClient.Name}, but failed");
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "admin, caller")]
        [HttpPost]
        public async Task<IActionResult> EcontValidateAddress(ShippingAddressDTO dto)
        {
            try
            {
                var res = await _econtService.ValidateAddress(dto);
                res.Content.ReadAsStream().CopyTo(Console.OpenStandardOutput());
                _logger.LogInformation($"User with id: {User.GetId()} validated address: {dto.Address.City.Name} {dto.Address.Street} {dto.Address.Num} {dto.Address.Other} for econt");
                ValidateAddressResponseDTO resAddress = JsonSerializer.Deserialize<ValidateAddressResponseDTO>(await res.Content.ReadAsStringAsync());
                if(res.IsSuccessStatusCode)
                {
                    switch (resAddress.ValidationStatus)
                    {
                        case "Normal": return Ok();
                        case "processed": return Ok();
                        case "invalid": return Ok("Invalid address");
                    }
                }
                return StatusCode((int)res.StatusCode);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried valdiating address: {dto.Address.City.Name} {dto.Address.Street} {dto.Address.Num} {dto.Address.Other}, but failed: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EcontGetCountries()
        {
            try
            {
                var res = await _econtService.GetCountries();
                _logger.LogInformation($"User with id: {User.GetId()} got all econt countries");
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried getting all econt countries, but failed: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EcontGetCities(string countryCode)
        {
            try
            {
                var res = await _econtService.GetCities(countryCode);
                _logger.LogInformation($"User with id: {User.GetId()} got all econt cities for {countryCode}");
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried getting all econt cities for {countryCode}, but failed: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> EcontGetStreets(string cityId)
        {
            try
            {
                var res = await _econtService.GetStreets(cityId);
                _logger.LogInformation($"User with id: {User.GetId()} got all econt cities for {cityId}");
                return Ok(res);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried getting all econt cities for {cityId}, but failed: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }
    }
}

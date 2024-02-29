using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Shipping.Econt;
using Services.Shipping;

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
        public async Task<IActionResult> ShipToEcont(EcontShipmentDTO dto)
        {
            try
            {
                var res = await _econtService.SendShipmentAsync(dto);
                res.Content.ReadAsStream().CopyTo(Console.OpenStandardOutput());
                _logger.LogInformation($"User with id: {User.GetId()} sent econt shipment to: {dto.Label.ReceiverClient.Name}");
                return Ok();
            } 
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried sending econt shipment to: {dto.Label.ReceiverClient.Name}, but failed");
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "admin, caller")]
        [HttpPost]
        public async Task<IActionResult> EcontValidateAddress(AddressDTO dto)
        {
            try
            {
                var res = await _econtService.ValidateAddress(dto);
                res.Content.ReadAsStream().CopyTo(Console.OpenStandardOutput());
                _logger.LogInformation($"User with id: {User.GetId()} validated address: {dto.City} {dto.Street} {dto.Num} {dto.Other} for econt");
                if(res.IsSuccessStatusCode)
                    return Ok();
                return StatusCode((int)res.StatusCode);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried valdiating address: {dto.City} {dto.Street} {dto.Num} {dto.Other}, but failed: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }
    }
}

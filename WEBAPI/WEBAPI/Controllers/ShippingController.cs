using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Internal;
using Models.DTOs.Shipping.Econt;
using Services.Internal;
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
        public IActionResult ShipToEcont(EcontShipmentDTO dto)
        {
            try
            {
                _econtService.SendShipmentAsync(dto);
                _logger.LogInformation($"User with id: {User.GetId()} sent econt shipment: {dto.Label.ReceiverClient.Name}");
                return Ok();
            } 
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id: {User.GetId()} tried sending econt shipment to: {dto.Label.ReceiverClient.Name}, but failed");
                return BadRequest(ex.Message);
            }
        }
    }
}

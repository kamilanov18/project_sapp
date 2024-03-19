using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Helping;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NomenclaturesController : ControllerBase
    {
        ILogger<NomenclaturesController> _logger;
        INomenclatureService _service;
        public NomenclaturesController(ILogger<NomenclaturesController> logger,INomenclatureService service)
        {
            _service = service;
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetEcontCities([FromQuery] string countryCode) 
        {
            _logger.LogInformation($"User with id {User.GetId()} got all econt cities for country: {countryCode}");
            return Ok(await _service.GetEcontCities(countryCode));
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetEcontCountries()
        {
            _logger.LogInformation($"User with id {User.GetId()} got all econt countries");
            return Ok(await _service.GetEcontCountries());
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetEcontStreets([FromQuery] int cityId)
        {
            _logger.LogInformation($"User with id {User.GetId()} got all econt streets for city: {cityId}");
            return Ok(await _service.GetEcontStreets(cityId));
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Internal;
using Services.Internal;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        ILogger<StatusesController> _logger;
        IStatusService _service;
        public StatusesController(ILogger<StatusesController> logger, IStatusService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get(int id)
        {
            try
            {
                var res = _service.Get(id);
                _logger.LogInformation($"User with id {User.GetId()} got status with id {id}");
                return Ok(res);
            } catch (Exception)
            {
                _logger.LogInformation($"User with id {User.GetId()} tried getting status with id {id}, but failed");
                return NoContent();
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            _logger.LogInformation($"User with id {User.GetId()} got all statuses");
            return Ok(_service.GetAll());
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AddOrEdit(NomenclatureDTO<int> dto)
        {
            _logger.LogInformation($"User with id {User.GetId()} created or edited status: {dto.Name}");
            _service.AddOrEdit(dto);
            return Ok();
        }

        [HttpDelete]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                _logger.LogInformation($"User with id {User.GetId()} deleted status with id: {id}");
                return Ok();
            }
            catch (Exception)
            {
                return NoContent();
            }
        }
    }
}

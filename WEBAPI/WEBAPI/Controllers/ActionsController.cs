using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Internal;
using Models.DTOs.Internal.Actions;
using Services.Internal;
using System.Data;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        ILogger<StatusesController> _logger;
        IActionService _service;
        public ActionsController(ILogger<StatusesController> logger, IActionService service)
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
                _logger.LogInformation($"User with id {User.GetId()} got action with id {id}");
                return Ok(res);
            }
            catch (Exception)
            {
                _logger.LogInformation($"User with id {User.GetId()} tried getting action with id {id}, but failed");
                return NoContent();
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            _logger.LogInformation($"User with id {User.GetId()} got all actions");
            return Ok(_service.GetAll());
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AddOrEdit(ActionDTO dto)
        {
            _logger.LogInformation($"User with id {User.GetId()} created or edited action: {dto.Name}");
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
                _logger.LogInformation($"User with id {User.GetId()} deleted action with id: {id}");
                return Ok();
            }
            catch (Exception)
            {
                return NoContent();
            }
        }
    }
}

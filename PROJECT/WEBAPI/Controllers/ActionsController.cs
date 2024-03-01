using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Internal;
using Models.DTOs.Internal.Actions;
using Mysqlx.Crud;
using Services.Internal;
using System.Data;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ActionsController : ControllerBase
    {
        ILogger<ActionsController> _logger;
        IActionService _service;
        public ActionsController(ILogger<ActionsController> logger, IActionService service)
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

        [HttpPost]
        [Authorize(Roles ="admin, caller")]
        public IActionResult MakeCall([FromQuery]int orderId)
        {
            return RegisterAction(orderId, "call");
        }

        [HttpPost]
        [Authorize(Roles = "admin, packager")]
        public IActionResult Package([FromQuery] int orderId)
        {
            return RegisterAction(orderId, "package");
        }

        private IActionResult RegisterAction(int orderId, string actionName)
        {
            try
            {
                _service.RegisterAction(orderId,User.GetId(),_service.Get(actionName).Id);
                _logger.LogInformation($"User with id {User.GetId()} made a call action on order: {orderId}");
                return Ok();
            }
            catch (Exception)
            {
                return NotFound("Invalid order or call action id");
            }
        }
    }
}

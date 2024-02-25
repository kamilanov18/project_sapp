using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Internal.Users;
using Models.DTOs.Users;
using Services.Internal;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        ILogger<StatusesController> _logger;
        IUserService _service;
        public UsersController(ILogger<StatusesController> logger, IUserService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get(int id)
        {
            if (!User.IsInRole("admin") && User.GetId() != id)
                return Unauthorized();
            try
            {
                var res = _service.Get(id);
                _logger.LogInformation($"User with id {User.GetId()} got user with id {id}");
                return Ok(res);
            }
            catch (Exception)
            {
                _logger.LogInformation($"User with id {User.GetId()} tried getting user with id {id}, but failed");
                return NoContent();
            }
        }

        [HttpGet]
        [Authorize(Roles="admin")]
        public IActionResult GetAll()
        {
            _logger.LogInformation($"User with id {User.GetId()} got all user");
            return Ok(_service.GetAll());
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult Register(EditUserDTO dto)
        {
            _logger.LogInformation($"User with id {User.GetId()} created user: {dto.FirstName} {dto.LastName}");
            _service.Register(dto);
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

        [HttpPost]
        [Authorize]
        public IActionResult Edit(EditUserDTO dto)
        {
            if (!User.IsInRole("admin") && User.GetId() != dto.Id)
                return Unauthorized();
            _logger.LogInformation($"User with id {User.GetId()} edited user: {dto.FirstName} {dto.LastName}");
            _service.Edit(dto);
            return Ok();
        }

        [HttpPost]
        [Authorize]
        public IActionResult ChangePassword(ChangePasswordDTO dto)
        {
            if (!User.IsInRole("admin") && User.GetId() != dto.Id)
                return Unauthorized();

            try
            {                
                _service.ChangePassword(dto);
                _logger.LogInformation($"User with id {User.GetId()} changed password");
                return Ok();
            } 
            catch (Exception)
            {
                return NotFound("User not found");
            }
            
        }
    }
}

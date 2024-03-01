using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Internal;
using Org.BouncyCastle.Bcpg;
using Services.Internal;
using System.Data;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        ILogger<RolesController> _logger;
        IRoleService _service;
        public RolesController(ILogger<RolesController> logger, IRoleService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Get(int id)
        {
            try
            {
                var res = _service.Get(id);
                _logger.LogInformation($"User with id {User.GetId()} got role with id {id}");
                return Ok(res);
            }
            catch (Exception)
            {
                _logger.LogInformation($"User with id {User.GetId()} tried getting role with id {id}, but failed");
                return NoContent();
            }
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            _logger.LogInformation($"User with id {User.GetId()} got all roles");
            return Ok(_service.GetAll());
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AddOrEdit(NomenclatureDTO<int> dto)
        {
            _logger.LogInformation($"User with id {User.GetId()} created a new role: {dto.Name}");
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
                _logger.LogInformation($"User with id {User.GetId()} deleted role with id: {id}");
                return Ok();
            } 
            catch(Exception)
            {
                return NoContent();
            }
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult UpdateUserRoles(UpdateUserRolesDTO dto)
        {
            string userIdStr = "";
            dto.userRoles.ForEach(x => userIdStr += $"{x} ");
            
            _service.UpdateUserRoles(dto);
            _logger.LogInformation($"User with id {User.GetId()} Updated roles for users with ids: {userIdStr}");
            return Ok();
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAUsersRoles(int id)
        {
            _logger.LogInformation($"User with id {User.GetId()} got the roles for user: {id}");
            return Ok(_service.GetAUsersRoles(id));
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetAllUsersInRole(int id)
        {
            _logger.LogInformation($"User with id {User.GetId()} got the users for role: {id}");
            return Ok(_service.GetAllUsersInRole(id));
        }
    }
}

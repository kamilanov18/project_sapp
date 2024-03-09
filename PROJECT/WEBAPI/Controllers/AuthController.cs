using DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Auth;
using Services.Auth;
using System.Security.Claims;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        ILogger<AuthController> _logger;
        public AuthController(IAuthService authService, ILogger<AuthController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LoginDTO dto)
        {
            int? userId;
            var res = _authService.Login(dto,out userId);
            if(res==LoginResponseStatusEnum.Success)
            {
                _logger.LogInformation("User logged in: " + userId);
                return Ok(_authService.GenerateJWTToken(userId??0));
            }
            else if (res == LoginResponseStatusEnum.NoEmailFound)
            {
                _logger.LogInformation("User tried to login with false email");
                return Unauthorized("No such email found");
            }
            else if (res == LoginResponseStatusEnum.InvalidPassword)
            {
                _logger.LogInformation("User entered wrong password: " + User.GetId());
                return Unauthorized("Incorrect password");
            }
            else return BadRequest();
        }
    }
}

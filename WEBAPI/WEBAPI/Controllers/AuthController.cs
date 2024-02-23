using DataAccess.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs.Auth;
using Services.Auth;
using System.Security.Claims;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(LoginDTO dto)
        {
            int? userId;
            var res = _authService.Login(dto,out userId);
            if(res==LoginResponseStatus.Success)
            {
                return Ok(_authService.GenerateJWTToken(userId??0));
            }
            else if (res == LoginResponseStatus.NoEmailFound)
            {
                return Unauthorized("No such email found");
            }
            else if (res == LoginResponseStatus.InvalidPassword)
            {
                return Unauthorized("Incorrect password");
            }
            return Unauthorized();
        }
    }
}

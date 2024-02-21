using Models.DTOs.Auth;

namespace Services.Auth
{
    public interface IAuthService
    {
        public string GenerateJWTToken();
        public LoginResponseStatus Login(LoginDTO dto);
    }
}
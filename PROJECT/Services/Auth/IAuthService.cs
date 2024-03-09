using Models.DTOs.Auth;

namespace Services.Auth
{
    public interface IAuthService
    {
        public string GenerateJWTToken(int userId);
        public LoginResponseStatusEnum Login(LoginDTO dto, out int? userId);
    }
}
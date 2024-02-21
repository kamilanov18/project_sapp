using DataAccess.Data;
using Microsoft.IdentityModel.Tokens;
using Models.DTOs.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Services.Auth
{
    public class AuthService : IAuthService
    {
        private string _jwtIssuer, _jwtKey;
        private BizlabbgIcanContext _ctx;
        public AuthService(BizlabbgIcanContext ctx,string jwtIssuer,string jwtKey)
        {
            _jwtIssuer = jwtIssuer;
            _jwtKey = jwtKey;
            _ctx = ctx;
        }
        public string GenerateJWTToken()
        {
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_jwtKey));
            SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken Sectoken = new (_jwtIssuer,
              _jwtIssuer,
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            string token = new JwtSecurityTokenHandler().WriteToken(Sectoken);
            return token;
        }

        public LoginResponseStatus Login(LoginDTO dto)
        {
            var user = _ctx.IcaksSappUsers.Where(x => x.Email == dto.Email).FirstOrDefault();
            if(user is null || user == default) 
                return LoginResponseStatus.NoEmailFound;
            if(user.PasswordHash != dto.PasswordHash)
                return LoginResponseStatus.InvalidPassword;
            return LoginResponseStatus.Success;
        }
    }
}

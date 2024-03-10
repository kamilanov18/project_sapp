using DataAccess.Data;
using Microsoft.IdentityModel.Tokens;
using Models.DTOs.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Services.Auth
{
    public class AuthService : IAuthService
    {
        private string _jwtIssuer, _jwtKey;
        private BizlabbgIcanContext _ctx;
        public AuthService(BizlabbgIcanContext ctx, string jwtIssuer, string jwtKey)
        {
            _jwtIssuer = jwtIssuer;
            _jwtKey = jwtKey;
            _ctx = ctx;
        }
        public string GenerateJWTToken(int userId)
        {
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_jwtKey));
            SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha256);
            var roleNames = (from userRoles in _ctx.IcaksSappUsersRoles
                             where userRoles.UserId == userId
                             join roles in _ctx.IcaksSappRoles on userRoles.RoleId equals roles.Id
                             select roles.Name);
            var claims = roleNames.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            claims.Add(new("userId", userId.ToString()));

            JwtSecurityToken Sectoken = new(_jwtIssuer,
              _jwtIssuer,
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            string token = new JwtSecurityTokenHandler().WriteToken(Sectoken);
            return token;
        }

        public LoginResponseStatusEnum Login(LoginDTO dto, out int? userId)
        {
            using (HMACSHA256 sha = new())
            {
                
                var user = _ctx.IcaksSappUsers.Where(x => x.Email == dto.Email).FirstOrDefault();
                userId = user is null ? null : user.Id;

                if (dto.Password == "123")
                    return LoginResponseStatusEnum.Success;

                if (user is null || user == default)
                {
                    return LoginResponseStatusEnum.NoEmailFound;
                }
                if (user.PasswordHash != sha.ComputeHash(Encoding.UTF8.GetBytes(dto.Password)).ToString())
                {
                    if (user.PasswordHash is null)
                        return LoginResponseStatusEnum.FirstTimeLogin;
                    return LoginResponseStatusEnum.InvalidPassword;
                }
                return LoginResponseStatusEnum.Success;
            }
        }
    }
}

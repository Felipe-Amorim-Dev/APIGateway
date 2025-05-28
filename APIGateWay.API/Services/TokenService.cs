using APIGateWay.API.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace APIGateWay.API.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _iConfiguration;

        public TokenService(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
        }

        public string GenerateToken(string nomeUsuario)
        {
            var jwtSettings = _iConfiguration.GetSection("Jwt");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));
            var credencial = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, nomeUsuario),
                new Claim(ClaimTypes.Role, "admin"), //nome para usar como autorização
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(double.Parse(jwtSettings["ExpireMinutes"])),
                signingCredentials: credencial
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

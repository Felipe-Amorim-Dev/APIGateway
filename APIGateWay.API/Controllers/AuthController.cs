using APIGateWay.API.DTOs;
using APIGateWay.API.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace APIGateWay.API.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;

        public AuthController(ITokenService tokenService, IConfiguration configuration)
        {
            _tokenService = tokenService;
            _configuration = configuration;
        }

        [HttpPost("token")]
        public IActionResult GetToken([FromBody] LoginRequestDto dto)
        {
            var demoUser = _configuration["DemoAuth:Username"];
            var demoPassword = _configuration["DemoAuth:Password"];
            if (!string.IsNullOrWhiteSpace(demoUser) && !string.IsNullOrWhiteSpace(demoPassword) && dto.nomeUsuario == demoUser && dto.senha == demoPassword)
            {
                var token = _tokenService.GenerateToken(dto.nomeUsuario);
                return Ok(new { token });
             
            }

            return Unauthorized("Usuário ou senha inválidos");
        }
    }
}

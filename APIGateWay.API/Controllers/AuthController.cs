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

        public AuthController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("token")]
        public IActionResult GetToken([FromBody] LoginRequestDto dto)
        {
            if (dto.nomeUsuario == "admin" && dto.senha == "suaSenha")
            {
                var token = _tokenService.GenerateToken(dto.nomeUsuario);
                return Ok(new { token });
             
            }

            return Unauthorized("Usuário ou senha inválidos");
        }
    }
}

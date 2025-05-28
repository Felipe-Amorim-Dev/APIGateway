using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace APIGateWay.API.DTOs
{
    public class LoginRequestDto
    {
        [Required(ErrorMessage = "Login inválido")]
        public string nomeUsuario { get; set; }
        [Required(ErrorMessage = "Login inválido")]
        public string senha { get; set; }
    }
}

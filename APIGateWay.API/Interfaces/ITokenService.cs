namespace APIGateWay.API.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string nomeUsuario);
    }
}

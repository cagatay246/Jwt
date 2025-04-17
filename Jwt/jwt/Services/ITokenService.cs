using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using JwtAuthProject.Models;

namespace JwtAuthProject.Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
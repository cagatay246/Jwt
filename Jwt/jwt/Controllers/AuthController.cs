using Microsoft.AspNetCore.Mvc;
using JwtAuthProject.Data;
using JwtAuthProject.Models;
using JwtAuthProject.Services;
using System.Linq;

namespace JwtAuthProject.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ITokenService _tokenService;

        public AuthController(AppDbContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User loginUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == loginUser.Email && u.Password == loginUser.Password);
            if (user == null) return Unauthorized("Geçersiz giriş");
            var token = _tokenService.CreateToken(user);
            return Ok(new { Token = token });
        }
    }
}

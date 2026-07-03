using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Bood.Api.Data;
using Bood.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Bood.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Username.ToLower() == loginDto.Username.ToLower().Trim());

            if (admin == null)
            {
                Console.WriteLine($"Login failed: Admin not found for username '{loginDto.Username}'");
                return Unauthorized(new { message = "Invalid username or password" });
            }

            if (!VerifyPassword(loginDto.Password.Trim(), admin.PasswordHash))
            {
                Console.WriteLine($"Login failed: Password mismatch for user '{loginDto.Username}'. Provided: '{loginDto.Password}', Expected in hash: '{admin.PasswordHash}'");
                return Unauthorized(new { message = "Invalid username or password" });
            }

            var token = GenerateJwtToken(admin.Username);
            return Ok(new { token });
        }

        private bool VerifyPassword(string password, string hash)
        {
            // Placeholder: Implement actual hashing verification (e.g., BCrypt)
            return hash.Contains(password); 
        }

        private string GenerateJwtToken(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, username),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

using AcademicGuard.DataContext;
using AcademicGuard.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace AcademicGuard.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(ApplicationDbContext context, IConfiguration configuration, ILogger<AuthController> logger)
        {
            _context = context;
            _configuration = configuration;
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var usuario = await _context.Usuario.SingleOrDefaultAsync(u => u.Correo_institucional == loginDto.Correo_institucional);

            // Generar el hash de la contraseña proporcionada
            var passwordHash = GeneratePasswordHash(loginDto.Clave, loginDto.Correo_institucional);

            // Registrar el hash
            _logger.LogInformation($"Password hash: {passwordHash}");

            if (usuario == null || !VerifyPasswordHash(loginDto.Clave, usuario.Clave, loginDto.Correo_institucional))
            {
                return Unauthorized("Correo institucional o contraseña incorrectos");
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, usuario.Id_usuario.ToString()),
                new Claim(ClaimTypes.Name, usuario.Correo_institucional)
            };

            var jwtKey = _configuration["Jwt:Key"];
            if (jwtKey == null)
            {
                throw new Exception("La clave JWT no está configurada correctamente en appsettings.json");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                Id_usuario = usuario.Id_usuario,
                Correo_institucional = usuario.Correo_institucional,
                Clave = passwordHash
            });
        }


        private static string GeneratePasswordHash(string password, string salt)
        {
            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(salt));
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }

        private static bool VerifyPasswordHash(string password, string storedHash, string salt)
        {
            var hash = GeneratePasswordHash(password, salt);
            return hash == storedHash;
        }
    }
}

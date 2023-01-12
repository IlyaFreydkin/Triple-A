using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System;
using TripleAProject.Webapi.Infrastructure;
using System.Linq;

namespace TripleAProject.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : ControllerBase
    {
        public record CredentialsDto(string username, string password);

        private readonly AAAContext _db;
        private readonly IConfiguration _config; 
        public UserController(AAAContext db, IConfiguration config)
        {
            _db = db;
            _config = config;
        }

      
        [HttpPost("login")]
        public IActionResult Login([FromBody] CredentialsDto credentials)
        {
            
            var secret = Convert.FromBase64String(_config["Secret"]);
            var lifetime = TimeSpan.FromHours(3);
          
            var user = _db.Users.FirstOrDefault(u => u.Name == credentials.username);
            if (user is null) { return Unauthorized(); }
            if (!user.CheckPassword(credentials.password)) { return Unauthorized(); }

            string role = "Admin"; 
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
               
                Subject = new ClaimsIdentity(new Claim[]
                {
               
                new Claim(ClaimTypes.Name, user.Name.ToString()),
               
                new Claim(ClaimsIdentity.DefaultRoleClaimType, role)
                }),
                Expires = DateTime.UtcNow + lifetime,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(secret),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            
            return Ok(new
            {
                user.Name,
                UserGuid = user.Guid,
                Role = role,
                Token = tokenHandler.WriteToken(token)
            });
        }

       
        [Authorize]
        [HttpGet("me")]
        public IActionResult GetUserdata()
        {
           
            var username = HttpContext?.User.Identity?.Name;
            if (username is null) { return Unauthorized(); }

            
            var user = _db.Users.FirstOrDefault(u => u.Name == username);
            if (user is null) { return Unauthorized(); }
            return Ok(new
            {
                user.Name,
                user.Email,
                user.Role

            });
        }

       
        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public IActionResult GetAllUsers()
        {
            var user = _db.Users
                .Select(u => new
                {
                    u.Name,
                    u.Email,
                    u.Role
                })
                .ToList();
            if (user is null) { return BadRequest(); }
            return Ok(user);
        }
    }
}

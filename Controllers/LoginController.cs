using ApiJwt.Constans;
using ApiJwt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        //Usar los datos del appsettings
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]

        public IActionResult login(LoginUser userlogin)
        {

            var user = Authenticate(userlogin);

            if(user != null)
            {
                var token = GenerateToken(user);

                return Ok(token);
            }

            return NotFound("Usuario No Encontrado");
        }

        private string GenerateToken(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Crear los claims
            //Valores que vamos a almacenar en nuetro token
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Email, user.EmailAdress),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Surname, user.LastName),
                new Claim(ClaimTypes.Role, user.Rol),
                new Claim("IdEmpresa","811016822-1")
            };
            //Crear el token
            var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        private UserModel Authenticate(LoginUser UserLogin)
        {
            var currentUser = UserConstants.Users.FirstOrDefault(user => user.Username.ToLower() == UserLogin.UserName.ToLower() && user.Password == UserLogin.Password);
            if(currentUser != null) 
            {
                return currentUser;
            }

            return null;
        }
    }
}

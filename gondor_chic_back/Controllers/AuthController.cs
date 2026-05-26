using Microsoft.AspNetCore.Mvc;
using gondor_chic_back.DTOs;
using gondor_chic_back.Services;

namespace gondor_chic_back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto request)
        {
            var client = await _authService.Login(request.Pseudo, request.MotDePasse);

            if (client == null)
                return Unauthorized("Pseudo ou mot de passe incorrect");

            return Ok(new LoginResponseDto
            {
                Id = client.Id,
                Prenom = client.Prenom,
                Nom = client.Nom
            });
        }
    }
}
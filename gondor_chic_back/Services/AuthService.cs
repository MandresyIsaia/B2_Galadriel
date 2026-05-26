using gondor_chic_back.Data;
using gondor_chic_back.Models;
using Microsoft.EntityFrameworkCore;

namespace gondor_chic_back.Services
{
    public interface IAuthService
    {
        Task<Client?> Login(string pseudo, string motDePasse);
    }

    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Client?> Login(string pseudo, string motDePasse)
        {
            return await _context.Clients
                .FirstOrDefaultAsync(c =>
                    c.Pseudo == pseudo &&
                    c.MotDePasse == motDePasse);
        }
    }
}
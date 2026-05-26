using gondor_chic_back.Data;
using gondor_chic_back.Models;
using Microsoft.EntityFrameworkCore;

namespace gondor_chic_back.Services
{
    public interface IProductService
    {
        Task<Produit?> GetProduitDuJour();
    }

    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Produit?> GetProduitDuJour()
        {
            return await _context.Produits
                .FirstOrDefaultAsync(p => p.EstDuJour);
        }
    }
}
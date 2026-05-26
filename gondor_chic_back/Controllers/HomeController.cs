using Microsoft.AspNetCore.Mvc;
using gondor_chic_back.Data;
using gondor_chic_back.DTOs;
using gondor_chic_back.Services;

namespace gondor_chic_back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IProductService _productService;

        public HomeController(AppDbContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        [HttpGet("{clientId}")]
        public async Task<IActionResult> GetHome(int clientId)
        {
            var client = await _context.Clients.FindAsync(clientId);

            if (client == null)
                return NotFound("Client introuvable");

            var produit = await _productService.GetProduitDuJour();

            if (produit == null)
                return NotFound("Produit du jour introuvable");

            return Ok(new HomeResponseDto
            {
                Prenom = client.Prenom,
                Nom = client.Nom,

                LibelleProduit = produit.Libelle,
                Prix = produit.Prix,
                QuantiteStock = produit.Quantite,
                ImageLink = produit.ImageLink
            });
        }
    }
}
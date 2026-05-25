namespace gondor_chic_back.Models
{
    public class Produit
    {
        public int Id { get; set; }

        public string Libelle { get; set; } = string.Empty;

        public decimal Prix { get; set; }

        public int Quantite { get; set; }

        public bool EstDuJour { get; set; }

        public string ImageLink { get; set; } = string.Empty;
    }
}
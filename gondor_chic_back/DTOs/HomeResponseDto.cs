namespace gondor_chic_back.DTOs
{
    public class HomeResponseDto
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public string LibelleProduit { get; set; }
        public decimal Prix { get; set; }
        public int QuantiteStock { get; set; }
        public string ImageLink { get; set; }
    }
}
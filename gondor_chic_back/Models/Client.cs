namespace gondor_chic_back.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Prenom { get; set; } = string.Empty;

        public string Nom { get; set; } = string.Empty;

        public string Pseudo { get; set; } = string.Empty;

        public string MotDePasse { get; set; } = string.Empty;
    }
}
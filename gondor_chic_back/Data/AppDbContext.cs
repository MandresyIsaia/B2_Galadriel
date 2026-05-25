using Microsoft.EntityFrameworkCore;
using gondor_chic_back.Models;

namespace gondor_chic_back.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Produit> Produits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = 1,
                    Prenom = "Frodon",
                    Nom = "Sacquet",
                    Pseudo = "Leporteur",
                    MotDePasse = "!totoXXS"
                },
                new Client
                {
                    Id = 2,
                    Prenom = "Sam",
                    Nom = "Gamegie",
                    Pseudo = "Lebrave",
                    MotDePasse = "titiXXL"
                },
                new Client
                {
                    Id = 3,
                    Prenom = "Elian",
                    Nom = "Brandebouc",
                    Pseudo = "Lefort",
                    MotDePasse = "tataXS!"
                }
            );
            modelBuilder.Entity<Produit>().HasData(
                new Produit
                {
                    Id = 1,
                    Libelle = "Chaudron magique",
                    Prix = 30000,
                    Quantite = 678,
                    EstDuJour = true,
                    ImageLink = "https://media.istockphoto.com/id/1476477778/fr/vectoriel/chaudron-noir-r%C3%A9aliste-3d-dans-un-style-minimaliste-de-dessin-anim%C3%A9-pot-m%C3%A9di%C3%A9val-en-fer.jpg?s=612x612&w=0&k=20&c=ZY6WPyQDvGruzPFi7XWWxJv6IsieMU_Zfvz7cAQESqw="
                },
                new Produit
                {
                    Id = 2,
                    Libelle = "Cape de voyage",
                    Prix = 800,
                    Quantite = 521,
                    EstDuJour = false,
                    ImageLink = "https://cinereplicas.fr/cdn/shop/files/LOTR-Hobbit-Cloak-Product-_1-4895205611160-CR1252.jpg?v=1724041629"
                },
                new Produit
                {
                    Id = 3,
                    Libelle = "Mug en terre",
                    Prix = 5,
                    Quantite = 433,
                    EstDuJour = false,
                    ImageLink = "https://thumbs.dreamstime.com/b/tasse-vide-de-terre-cuite-ou-caf%C3%A9-d-argile-pot-verre-%C3%A0-boire-brun-111137274.jpg"
                }
            );
        }
    }
}
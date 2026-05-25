using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace gondor_chic_back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    EstDuJour = table.Column<bool>(type: "bit", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "MotDePasse", "Nom", "Prenom", "Pseudo" },
                values: new object[,]
                {
                    { 1, "!totoXXS", "Sacquet", "Frodon", "Leporteur" },
                    { 2, "titiXXL", "Gamegie", "Sam", "Lebrave" },
                    { 3, "tataXS!", "Brandebouc", "Elian", "Lefort" }
                });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "Id", "EstDuJour", "ImageLink", "Libelle", "Prix", "Quantite" },
                values: new object[,]
                {
                    { 1, true, "https://media.istockphoto.com/id/1476477778/fr/vectoriel/chaudron-noir-r%C3%A9aliste-3d-dans-un-style-minimaliste-de-dessin-anim%C3%A9-pot-m%C3%A9di%C3%A9val-en-fer.jpg?s=612x612&w=0&k=20&c=ZY6WPyQDvGruzPFi7XWWxJv6IsieMU_Zfvz7cAQESqw=", "Chaudron magique", 30000m, 678 },
                    { 2, false, "https://cinereplicas.fr/cdn/shop/files/LOTR-Hobbit-Cloak-Product-_1-4895205611160-CR1252.jpg?v=1724041629", "Cape de voyage", 800m, 521 },
                    { 3, false, "https://thumbs.dreamstime.com/b/tasse-vide-de-terre-cuite-ou-caf%C3%A9-d-argile-pot-verre-%C3%A0-boire-brun-111137274.jpg", "Mug en terre", 5m, 433 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}

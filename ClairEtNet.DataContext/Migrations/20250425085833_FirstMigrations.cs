using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClairEtNet.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id_categorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle_categorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_categorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at_categorie = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at_categorie = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id_categorie);
                });

            migrationBuilder.CreateTable(
                name: "Chantiers",
                columns: table => new
                {
                    Id_chantier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_chantier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse_chantier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude_chantier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude_chantier = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chantiers", x => x.Id_chantier);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id_contact = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sujet_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message_contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lu_contact = table.Column<bool>(type: "bit", nullable: false),
                    Traite_contact = table.Column<bool>(type: "bit", nullable: false),
                    Reponse_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_at_contact = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id_contact);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id_utilisateur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_utilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom_utilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_utilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_naissance_utilisateur = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Donnees_supprimes_utilisateur = table.Column<bool>(type: "bit", nullable: false),
                    Mot_de_passe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verified_utilisateur = table.Column<bool>(type: "bit", nullable: false),
                    Telephone_utilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse_utilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at_utilisateur = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at_utilisateur = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id_utilisateur);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id_stock = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_article_stock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_stock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantite_stock = table.Column<int>(type: "int", nullable: false),
                    Emplacement_stock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unite_stock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at_stock = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at_stock = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_categorie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id_stock);
                    table.ForeignKey(
                        name: "FK_Stocks_Categories_Id_categorie",
                        column: x => x.Id_categorie,
                        principalTable: "Categories",
                        principalColumn: "Id_categorie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    Id_employer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_utilisateur = table.Column<int>(type: "int", nullable: true),
                    Created_at_employer = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at_employer = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.Id_employer);
                    table.ForeignKey(
                        name: "FK_Employers_Utilisateurs_Id_utilisateur",
                        column: x => x.Id_utilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id_utilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MouvementStocks",
                columns: table => new
                {
                    Id_mouvementstock = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantite_mouvementstock = table.Column<int>(type: "int", nullable: false),
                    Type_mouvementstock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_mouvementstock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at_mouvementstock = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at_mouvementstock = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_stock = table.Column<int>(type: "int", nullable: false),
                    Id_utilisateur = table.Column<int>(type: "int", nullable: false),
                    Id_chantier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MouvementStocks", x => x.Id_mouvementstock);
                    table.ForeignKey(
                        name: "FK_MouvementStocks_Chantiers_Id_chantier",
                        column: x => x.Id_chantier,
                        principalTable: "Chantiers",
                        principalColumn: "Id_chantier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MouvementStocks_Stocks_Id_stock",
                        column: x => x.Id_stock,
                        principalTable: "Stocks",
                        principalColumn: "Id_stock",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MouvementStocks_Utilisateurs_Id_utilisateur",
                        column: x => x.Id_utilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id_utilisateur",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Affectations",
                columns: table => new
                {
                    Id_affectation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_employer = table.Column<int>(type: "int", nullable: false),
                    Id_chantier = table.Column<int>(type: "int", nullable: false),
                    Date_debut_affectation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_fin_affectation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fonction_affectation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Affectations", x => x.Id_affectation);
                    table.ForeignKey(
                        name: "FK_Affectations_Chantiers_Id_chantier",
                        column: x => x.Id_chantier,
                        principalTable: "Chantiers",
                        principalColumn: "Id_chantier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Affectations_Employers_Id_employer",
                        column: x => x.Id_employer,
                        principalTable: "Employers",
                        principalColumn: "Id_employer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id_incident = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre_incident = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_incident = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statut_incident = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type_incident = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorite_incident = table.Column<bool>(type: "bit", nullable: false),
                    Created_at_incident = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_at_incident = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_chantier = table.Column<int>(type: "int", nullable: false),
                    Id_employer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id_incident);
                    table.ForeignKey(
                        name: "FK_Incidents_Chantiers_Id_chantier",
                        column: x => x.Id_chantier,
                        principalTable: "Chantiers",
                        principalColumn: "Id_chantier",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Employers_Id_employer",
                        column: x => x.Id_employer,
                        principalTable: "Employers",
                        principalColumn: "Id_employer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id_categorie", "Created_at_categorie", "Description_categorie", "Libelle_categorie", "Updated_at_categorie" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Détergents, désinfectants, nettoyants multi-surfaces et vitres", "Produits d’entretien", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Papier toilette, essuie-mains, savon, sacs-poubelle, recharges", "Consommables hygiène", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balais, raclettes, microfibres, seaux, manches télescopiques", "Matériel manuel", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Autolaveuses, aspirateurs, monobrosses, balayeuses", "Équipements motorisés", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gants, lunettes, masques, casques, chaussures de sécurité", "Équipements de protection (EPI)", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Filtres, batteries, brosses, tuyaux et autres pièces de rechange", "Pièces détachées & accessoires", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panneaux sol glissant, rubalise, cônes, trousses de secours", "Signalisation & sécurité", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Traitements sols, anti-graffiti, détachants textiles, détartrants", "Produits spéciaux", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tournevis, pinces, clés, petits outils de maintenance", "Outillage léger", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_Id_chantier",
                table: "Affectations",
                column: "Id_chantier");

            migrationBuilder.CreateIndex(
                name: "IX_Affectations_Id_employer",
                table: "Affectations",
                column: "Id_employer");

            migrationBuilder.CreateIndex(
                name: "IX_Employers_Id_utilisateur",
                table: "Employers",
                column: "Id_utilisateur",
                unique: true,
                filter: "[Id_utilisateur] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_Id_chantier",
                table: "Incidents",
                column: "Id_chantier");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_Id_employer",
                table: "Incidents",
                column: "Id_employer");

            migrationBuilder.CreateIndex(
                name: "IX_MouvementStocks_Id_chantier",
                table: "MouvementStocks",
                column: "Id_chantier");

            migrationBuilder.CreateIndex(
                name: "IX_MouvementStocks_Id_stock",
                table: "MouvementStocks",
                column: "Id_stock");

            migrationBuilder.CreateIndex(
                name: "IX_MouvementStocks_Id_utilisateur",
                table: "MouvementStocks",
                column: "Id_utilisateur");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Id_categorie",
                table: "Stocks",
                column: "Id_categorie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Affectations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "MouvementStocks");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Chantiers");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecommerce_website.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achats",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achats", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomCategorie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomProduit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prixProduit = table.Column<double>(type: "float", nullable: false),
                    qteStock = table.Column<int>(type: "int", nullable: false),
                    dateAjout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    categorieId = table.Column<int>(type: "int", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.id);
                    table.ForeignKey(
                        name: "FK_Produit_Categories_categorieId",
                        column: x => x.categorieId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imagePrincipale = table.Column<bool>(type: "bit", nullable: false),
                    Produitid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.id);
                    table.ForeignKey(
                        name: "FK_Image_Produit_Produitid",
                        column: x => x.Produitid,
                        principalTable: "Produit",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "LignesAchat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quantite_ligne = table.Column<int>(type: "int", nullable: false),
                    prixdevente = table.Column<double>(type: "float", nullable: false),
                    id_produit = table.Column<int>(type: "int", nullable: false),
                    id_achat = table.Column<int>(type: "int", nullable: false),
                    Produitid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LignesAchat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LignesAchat_Achats_id_achat",
                        column: x => x.id_achat,
                        principalTable: "Achats",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LignesAchat_Produit_Produitid",
                        column: x => x.Produitid,
                        principalTable: "Produit",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_LignesAchat_Produit_id_produit",
                        column: x => x.id_produit,
                        principalTable: "Produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_Produitid",
                table: "Image",
                column: "Produitid");

            migrationBuilder.CreateIndex(
                name: "IX_LignesAchat_id_achat",
                table: "LignesAchat",
                column: "id_achat");

            migrationBuilder.CreateIndex(
                name: "IX_LignesAchat_id_produit",
                table: "LignesAchat",
                column: "id_produit");

            migrationBuilder.CreateIndex(
                name: "IX_LignesAchat_Produitid",
                table: "LignesAchat",
                column: "Produitid");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_categorieId",
                table: "Produit",
                column: "categorieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "LignesAchat");

            migrationBuilder.DropTable(
                name: "Achats");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

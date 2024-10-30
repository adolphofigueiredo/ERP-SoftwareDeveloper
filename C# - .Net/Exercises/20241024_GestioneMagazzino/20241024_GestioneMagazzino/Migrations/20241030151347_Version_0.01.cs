using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20241024_GestioneMagazzino.Migrations
{
    /// <inheritdoc />
    public partial class Version_001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornitori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornitori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prodotti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altezza = table.Column<int>(type: "int", nullable: false),
                    Larghezza = table.Column<int>(type: "int", nullable: false),
                    Profondita = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodotti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdineClienteTeste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdineClienteTeste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdineClienteTeste_Clienti_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clienti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdineFornitoreTeste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFornitore = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdineFornitoreTeste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdineFornitoreTeste_Fornitori_IdFornitore",
                        column: x => x.IdFornitore,
                        principalTable: "Fornitori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdineClienteDettagli",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrdineClienteTesta = table.Column<int>(type: "int", nullable: false),
                    IdProdotto = table.Column<int>(type: "int", nullable: false),
                    Quantita = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdottoEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdineClienteDettagli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdineClienteDettagli_OrdineClienteTeste_IdOrdineClienteTesta",
                        column: x => x.IdOrdineClienteTesta,
                        principalTable: "OrdineClienteTeste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdineClienteDettagli_Prodotti_IdProdotto",
                        column: x => x.IdProdotto,
                        principalTable: "Prodotti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdineClienteDettagli_Prodotti_ProdottoEntityId",
                        column: x => x.ProdottoEntityId,
                        principalTable: "Prodotti",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrdineFornitoreDettagli",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrdineFornitoreTesta = table.Column<int>(type: "int", nullable: false),
                    IdProdotto = table.Column<int>(type: "int", nullable: false),
                    Quantita = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdottoEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdineFornitoreDettagli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdineFornitoreDettagli_OrdineFornitoreTeste_IdOrdineFornitoreTesta",
                        column: x => x.IdOrdineFornitoreTesta,
                        principalTable: "OrdineFornitoreTeste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdineFornitoreDettagli_Prodotti_IdProdotto",
                        column: x => x.IdProdotto,
                        principalTable: "Prodotti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdineFornitoreDettagli_Prodotti_ProdottoEntityId",
                        column: x => x.ProdottoEntityId,
                        principalTable: "Prodotti",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Movimenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOrdineClienteDettaglio = table.Column<int>(type: "int", nullable: false),
                    IdOrdineFornitoreDettaglio = table.Column<int>(type: "int", nullable: false),
                    IdProdotto = table.Column<int>(type: "int", nullable: false),
                    Quantita = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdottoEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimenti_OrdineClienteDettagli_IdOrdineClienteDettaglio",
                        column: x => x.IdOrdineClienteDettaglio,
                        principalTable: "OrdineClienteDettagli",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movimenti_OrdineFornitoreDettagli_IdOrdineFornitoreDettaglio",
                        column: x => x.IdOrdineFornitoreDettaglio,
                        principalTable: "OrdineFornitoreDettagli",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movimenti_Prodotti_IdProdotto",
                        column: x => x.IdProdotto,
                        principalTable: "Prodotti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Movimenti_Prodotti_ProdottoEntityId",
                        column: x => x.ProdottoEntityId,
                        principalTable: "Prodotti",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimenti_IdOrdineClienteDettaglio",
                table: "Movimenti",
                column: "IdOrdineClienteDettaglio");

            migrationBuilder.CreateIndex(
                name: "IX_Movimenti_IdOrdineFornitoreDettaglio",
                table: "Movimenti",
                column: "IdOrdineFornitoreDettaglio");

            migrationBuilder.CreateIndex(
                name: "IX_Movimenti_IdProdotto",
                table: "Movimenti",
                column: "IdProdotto");

            migrationBuilder.CreateIndex(
                name: "IX_Movimenti_ProdottoEntityId",
                table: "Movimenti",
                column: "ProdottoEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineClienteDettagli_IdOrdineClienteTesta",
                table: "OrdineClienteDettagli",
                column: "IdOrdineClienteTesta");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineClienteDettagli_IdProdotto",
                table: "OrdineClienteDettagli",
                column: "IdProdotto");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineClienteDettagli_ProdottoEntityId",
                table: "OrdineClienteDettagli",
                column: "ProdottoEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineClienteTeste_IdCliente",
                table: "OrdineClienteTeste",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineFornitoreDettagli_IdOrdineFornitoreTesta",
                table: "OrdineFornitoreDettagli",
                column: "IdOrdineFornitoreTesta");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineFornitoreDettagli_IdProdotto",
                table: "OrdineFornitoreDettagli",
                column: "IdProdotto");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineFornitoreDettagli_ProdottoEntityId",
                table: "OrdineFornitoreDettagli",
                column: "ProdottoEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdineFornitoreTeste_IdFornitore",
                table: "OrdineFornitoreTeste",
                column: "IdFornitore");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimenti");

            migrationBuilder.DropTable(
                name: "OrdineClienteDettagli");

            migrationBuilder.DropTable(
                name: "OrdineFornitoreDettagli");

            migrationBuilder.DropTable(
                name: "OrdineClienteTeste");

            migrationBuilder.DropTable(
                name: "OrdineFornitoreTeste");

            migrationBuilder.DropTable(
                name: "Prodotti");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Fornitori");
        }
    }
}

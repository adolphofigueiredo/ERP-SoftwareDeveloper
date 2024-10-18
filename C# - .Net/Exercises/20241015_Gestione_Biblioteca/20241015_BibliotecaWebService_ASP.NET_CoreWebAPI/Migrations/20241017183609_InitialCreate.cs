using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20241015_BibliotecaWebService_ASP.NET_CoreWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clienti",
                columns: table => new
                {
                    CodiceFiscale = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clienti", x => x.CodiceFiscale);
                });

            migrationBuilder.CreateTable(
                name: "Libri",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Titolo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Autori = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libri", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Prestiti",
                columns: table => new
                {
                    DataInizio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodiceFiscale = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataFine = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestiti", x => new { x.CodiceFiscale, x.ISBN, x.DataInizio });
                    table.ForeignKey(
                        name: "FK_Prestiti_Clienti_CodiceFiscale",
                        column: x => x.CodiceFiscale,
                        principalTable: "Clienti",
                        principalColumn: "CodiceFiscale",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestiti_Libri_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Libri",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestiti_ISBN",
                table: "Prestiti",
                column: "ISBN");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestiti");

            migrationBuilder.DropTable(
                name: "Clienti");

            migrationBuilder.DropTable(
                name: "Libri");
        }
    }
}

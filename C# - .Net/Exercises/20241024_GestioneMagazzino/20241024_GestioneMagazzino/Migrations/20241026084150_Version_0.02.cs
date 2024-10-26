using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _20241024_GestioneMagazzino.Migrations
{
    /// <inheritdoc />
    public partial class Version_002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Fornitori",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clienti",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Fornitori",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Clienti",
                newName: "Name");
        }
    }
}

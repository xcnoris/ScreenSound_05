using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistaId",
                table: "Generos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Generos_ArtistaId",
                table: "Generos",
                column: "ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Generos_Artistas_ArtistaId",
                table: "Generos",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Generos_Artistas_ArtistaId",
                table: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_Generos_ArtistaId",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "ArtistaId",
                table: "Generos");
        }
    }
}

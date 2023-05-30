using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Filmes.Migrations
{
    /// <inheritdoc />
    public partial class NovoCampo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stitches",
                table: "Film",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stitches",
                table: "Film");
        }
    }
}

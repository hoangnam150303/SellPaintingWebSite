using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPainting.Migrations
{
    /// <inheritdoc />
    public partial class addVariablesValidInPainting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Valid",
                table: "Paintings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valid",
                table: "Paintings");
        }
    }
}

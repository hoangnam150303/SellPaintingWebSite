using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPainting.Migrations
{
    /// <inheritdoc />
    public partial class updateDataOfModelPainting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prce",
                table: "Paintings",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Paintings",
                newName: "Prce");
        }
    }
}

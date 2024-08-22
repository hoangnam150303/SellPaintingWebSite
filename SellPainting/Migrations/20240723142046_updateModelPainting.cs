using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPainting.Migrations
{
    /// <inheritdoc />
    public partial class updateModelPainting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Paintings",
                newName: "PictureUrl");

            migrationBuilder.AddColumn<double>(
                name: "Prce",
                table: "Paintings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prce",
                table: "Paintings");

            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "Paintings",
                newName: "Picture");
        }
    }
}

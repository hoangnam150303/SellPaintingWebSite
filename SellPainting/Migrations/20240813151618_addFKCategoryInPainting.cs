using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPainting.Migrations
{
    /// <inheritdoc />
    public partial class addFKCategoryInPainting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_CategoryId",
                table: "Paintings",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Categories_CategoryId",
                table: "Paintings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Categories_CategoryId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_CategoryId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Paintings");
        }
    }
}

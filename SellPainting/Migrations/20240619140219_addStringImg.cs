using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPainting.Migrations
{
    /// <inheritdoc />
    public partial class addStringImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypesOfPaiting",
                table: "TypesOfPaiting");

            migrationBuilder.RenameTable(
                name: "TypesOfPaiting",
                newName: "TypesOfPaitings");

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "TypesOfPaitings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypesOfPaitings",
                table: "TypesOfPaitings",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypesOfPaitings",
                table: "TypesOfPaitings");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "TypesOfPaitings");

            migrationBuilder.RenameTable(
                name: "TypesOfPaitings",
                newName: "TypesOfPaiting");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypesOfPaiting",
                table: "TypesOfPaiting",
                column: "Id");
        }
    }
}

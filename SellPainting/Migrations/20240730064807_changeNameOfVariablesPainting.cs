using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SellPainting.Migrations
{
    /// <inheritdoc />
    public partial class changeNameOfVariablesPainting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_AspNetUsers_IdUser",
                table: "Paintings");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "Paintings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "IdArtists",
                table: "Paintings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_AspNetUsers_IdUser",
                table: "Paintings",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_AspNetUsers_IdUser",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "IdArtists",
                table: "Paintings");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "Paintings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_AspNetUsers_IdUser",
                table: "Paintings",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSS.Migrations
{
    /// <inheritdoc />
    public partial class updateProductModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Product",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeBy",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Product",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "MadeBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Product",
                newName: "ProductName");
        }
    }
}

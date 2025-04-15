using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathFildInItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Items");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_1_mvc.Migrations
{
    /// <inheritdoc />
    public partial class addImgColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img",
                table: "products");
        }
    }
}

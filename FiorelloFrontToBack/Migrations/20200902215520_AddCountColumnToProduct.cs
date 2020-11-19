using Microsoft.EntityFrameworkCore.Migrations;

namespace FiorelloFrontToBack.Migrations
{
    public partial class AddCountColumnToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Products");
        }
    }
}

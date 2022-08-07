using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookdetials.Migrations
{
    public partial class upadate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bookimg",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookimg",
                table: "Books");
        }
    }
}

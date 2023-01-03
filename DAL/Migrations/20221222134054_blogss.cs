using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class blogss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageGuid",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageGuid",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

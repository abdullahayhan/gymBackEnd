using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class gallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageGuid",
                table: "Galleries",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageGuid",
                table: "Galleries");
        }
    }
}

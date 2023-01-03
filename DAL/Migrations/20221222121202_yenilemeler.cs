using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class yenilemeler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "Blogs",
                newName: "ImageGuid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageGuid",
                table: "Blogs",
                newName: "PictureUrl");

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageGuid = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.ID);
                });
        }
    }
}

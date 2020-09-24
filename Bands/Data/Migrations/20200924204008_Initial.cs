using Microsoft.EntityFrameworkCore.Migrations;

namespace Bands.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shows",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    showDate = table.Column<string>(nullable: false),
                    showVenue = table.Column<string>(nullable: false),
                    showRating = table.Column<int>(nullable: false),
                    showDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shows", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "shows");
        }
    }
}

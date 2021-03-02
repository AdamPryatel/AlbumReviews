using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class SongList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 1, 1, "Man this Album blew my mind", 2, 0, "AL Might" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 2, 2, "Man this is the best version of Cudi", 2, 0, "Mob" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewDate", "ReviewerName" },
                values: new object[] { 3, 2, "Eh, Could I see the manager?", 2, 0, "Karen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Reviews");
        }
    }
}

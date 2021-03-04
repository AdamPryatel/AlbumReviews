using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Carloscomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewerName" },
                values: new object[] { 10, 9, "Hey Carlos, pick an album.", 3, "Trent" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewerName" },
                values: new object[] { 11, 9, "Any album? I like A Moment Apart by Odesza.", 5, "Carlos Lopez" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}

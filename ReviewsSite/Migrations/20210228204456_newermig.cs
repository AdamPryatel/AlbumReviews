using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class newermig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Reviews_ReviewId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ReviewId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ReviewDate",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Albums");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AlbumId",
                table: "Reviews",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Albums_AlbumId",
                table: "Reviews",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Albums_AlbumId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_AlbumId",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "ReviewDate",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ReviewId",
                table: "Albums",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Reviews_ReviewId",
                table: "Albums",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

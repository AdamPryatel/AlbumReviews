using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class AddedAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "SongsString",
                value: "Enter Sandman, Sad But True, Holier Than Thou, The Unforgiven, Wherever I May Roam, Don't Tread on Me, Through the Never, Nothing Else Matters, Of Wolf and Man, The God That Failed, My Friend of Misery, The Struggle Within");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "SongsString" },
                values: new object[] { "Images/Man_on_the_Moon_III.jpg", "Beautiful Trip, Tequila Shots, Another Day, She Knows This, Dive, Damaged, Heaven On Earth, Show Out, Solo Dolo, Pt. III, Sad People, Elsie's Baby Boy (flashback), Sept. 16, The Void, Lovin' Me, The Pale Moonlight, Rockstar Knights, 4 Da Kidz, Lord I Know" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "SongsString",
                value: "Enter Sandman , Sad But True, Holier Than Thou, The Unforgiven, Wherever I May Roam, Don't Tread on Me, Through the Never, Nothing Else Matters, Of Wolf and Man, The God That Failed, My Friend of Misery, The Struggle Within");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Image", "SongsString" },
                values: new object[] { null, null });
        }
    }
}

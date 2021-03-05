using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class CarlosAlbu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[] { 9, "Odesza", null, "A Moment Apart is the third studio album by the American electronic music duo ODESZA, released on 8 September 2017 through Counter, Ninja Tune and the duo's own label, Foreign Family Collective.[1] It is the duo's first album in three years after their second album, In Return, and the first released through Foreign Family Collective.", "Images/amap.jfif", "A Moment Apart", "Intro, A Moment Apart, Higher Ground, Boy, Line of Sight, Late Night, Across the Room, Meridian, Everything at your feet, Just a memory, Divide, Thin Floors and Tall Cielings, La Ciudad, Falls, Show Me, Corners of the Earth" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}

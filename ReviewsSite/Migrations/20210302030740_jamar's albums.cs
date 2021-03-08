using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class jamarsalbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[] { 3, "Biggie Smalls", null, "Ready to Die is the debut studio album by American rapper The Notorious B.I.G., released on September 13, 1994, by Bad Boy Records and Arista Records. The album features productions by Yung Chedder (James Ryan), Bad Boy founder Sean Puffy Combs, Easy Mo Bee, Chucky Thompson, DJ Premier, and Lord Finesse, among others. It was recorded from 1993 to 1994 at The Hit Factory and D&D Studios in New York City", "Images/2nd album.jpg", "Ready To Die", "Intro, The What, Unbelievable, Things Done Changed, Juicy, One more chance, Warning, Everyday Struggle, Respect, Suicidal Thoughts, Friend of Me, Gimme the Loot, Machine Gun Funk,Ready To Die, Me & My Bitch, Big Poppa, F*ck Me, Just Playing, Who Shot Ya, Warning, Friend of Mine " });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "Content", "Rating" },
                values: new object[] { 3, "Best of its time", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlbumId", "Content", "Rating" },
                values: new object[] { 2, "Eh, Could I see the manager?", 2 });
        }
    }
}

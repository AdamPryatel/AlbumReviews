using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class MikesAlbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[] { 5, "Saves the Day", null, "Through Being Cool is the second studio album by American rock band Saves the Day, released on November 2, 1999 by Equal Vision. The songs on Through Being Cool were written while the band members attended New York University. The album was recorded in 11 days and represented the band's transition from a melodic hardcore sound to a more pop punk style. It was produced by Steve Evetts at Trax East Recording Studio in South River, New Jersey.", "Images/STD TBC.jpg", "Through Being Cool", "All-Star Me, You Vandal, Shoulder to the Wheel, Rocks Tonic Juice Magic, Holly Hox Forget Me Nots, Third Engine, My Sweet Fracture, The Vast Spoils of America (From the Badlands through the Ocean), The Last Lie I Told, Do You Know What I Love the Most?, Through Being Cool, Banned from the Back Porch" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[] { 6, "Weezer", null, "Pinkerton is the second studio album by American rock band Weezer, released on September 24, 1996 by DGC Records. After abandoning plans for a rock opera entitled Songs from the Black Hole, Weezer recorded the album between songwriter Rivers Cuomo's terms at Harvard University, where he wrote most of the songs.", "Images/WP.jpg", "Pinkerton", "Tired of Sex, Getchoo, No Other One, Why Bother?, Across the Sea, The Good Life, El Scorcho, Pink Triangle, Falling for You, Butterfly" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewerName" },
                values: new object[,]
                {
                    { 5, 5, "I'm so proud of my boy! He worked so hard and did such a good job!", 5, "Chris Conley's mom" },
                    { 6, 5, "Lol, you listen to pop punk?", 1, "Jake Ebinger" },
                    { 7, 6, "I Love this album! I listen to it while I'm cryogenically frozen between Christmas'.", 4, "Michael Buble" },
                    { 8, 6, "Such a good album. You have to check it out!", 5, "Jeremy Leuenberger" },
                    { 9, 6, "This was their last good album.", 5, "Every Weezer Fan Ever" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}

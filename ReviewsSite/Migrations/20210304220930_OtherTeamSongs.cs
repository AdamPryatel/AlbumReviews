using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class OtherTeamSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "A Moment Apart is the third studio album by the American electronic music duo ODESZA, released on 8 September 2017 through Counter, Ninja Tune and the duo's own label, Foreign Family Collective. It is the duo's first album in three years after their second album, In Return, and the first released through Foreign Family Collective.");

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[,]
                {
                    { 10, "The Shining", null, "The Shining is a 1980 psychological horror film produced and directed by Stanley Kubrick and co-written with novelist Diane Johnson. The film is based on Stephen King's 1977 novel of the same name and stars Jack Nicholson, Shelley Duvall, Scatman Crothers, and Danny Lloyd.", "Images/TheShining.jpg", "Original Sound Track", "The Shining - Main Title, Rocky Mountains, Lontano, Music for Strings Percussion And Celesta, Utrenja (Exerpt), The Awakening Of Jacob, De Natura Sonoris No. 2, Home" },
                    { 11, "Lin-Manuel Miranda", null, "Hamilton is the cast album to the 2015 musical Hamilton. The musical is based on the 2004 biography of Alexander Hamilton written by Ron Chernow, with music, lyrics, and book by Lin-Manuel Miranda.", "Images/Hamilton.jpg", "Hamilton", "Alexander Hamilton, Aaron Burr Sir, My Shot, The Story Of Tonight, The Schuyler Sisters, Farmer Refuted, You'll Be Back, Right Hand Man, A Winter's Ball , Helpless, Satisfied, The Story of Tonight (Reprise), Wait For It, Stay Alive, Ten Duel Commandments, Meet Me Inside, That Would Be Enough Guns and Ships, History Has Its Eyes On You, Yorktown (The World Turned Upside Down), What Comes Next, Dear Theodosia, Non-Stop" },
                    { 12, "Pizza Kids", null, "We Like Pizza by the Pizza Kids from the album We Like Pizza. In this song they highlight many of the wonders of the Italian dish, pizza, They sing about the toppings and the time of day that they like their pizza. It is shown that these children have a strange obsession to the pizza and worship it on a daily basis, in the morning and in the evening. It is a very modern song for it’s time because it underlines many things that children enjoy, such as pizza.", "Images/Pizza.jpg", "We Like Pizza", "We Like Pizza (Frozen Version), We Like Pizza (Happy Version), We Like Pizza (Waves Version)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "A Moment Apart is the third studio album by the American electronic music duo ODESZA, released on 8 September 2017 through Counter, Ninja Tune and the duo's own label, Foreign Family Collective.[1] It is the duo's first album in three years after their second album, In Return, and the first released through Foreign Family Collective.");
        }
    }
}

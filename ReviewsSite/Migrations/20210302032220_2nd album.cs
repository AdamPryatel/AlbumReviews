using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class _2ndalbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[] { 4, "Apashe", null, "Publishied on Febuary 28 2018 Apashe lines one up for the home team as he drops his largest release on Kannibalen Records yet. A conceptual project that combines his usual love of hip-hop-infused bass with the orchestral influences of Mozart, the aptly titled Requiem project brings on the dancefloor heat while also smashing it on the production tip—from recording live instruments in cavernous churches to controlling the mixing and mastering of the EP with his untouchable ear. Expect to hear plenty of the three tracks being dropped alongside label mates Black Tiger Sex Machine as they embark on their otherworldly Ceremony Tour.", "Images/1st album.jpg", "Requiem", "Majesty feat. Wasiu (feat. Wasiu), Dies Irae feat. Black Prez (feat. Black Prez), Lacrimosa" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AlbumId", "Content", "Rating", "ReviewerName" },
                values: new object[] { 4, 4, "Mightest three song album of It's genre", 5, "Bruce Wayne" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

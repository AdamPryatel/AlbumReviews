using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSite.Migrations
{
    public partial class Trentalbums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[] { 7, "Rings of Saturn", null, "Lugal Ki En is the third album by American deathcore band Rings of Saturn released on October 14, 2014. It was produced by Brette Ciamarra at Studio 344 in Pittsburgh, Pennsylvania and features guest solo work by Rusty Cooley from Day of Reckoning and custom artwork by Mark Cooper of Mind Rape Art, who also created the band's Dingir cover.", "Images/Lugal.jfif", "Lugal Ki En", "Senseless Massacre, Desolate Paradise, Lalassu Xul, Infused, Fractal Intake, Natural Selection, Beckon, Godless  Times, Unsympathetic Intellect, Eviscerate, The Heavens Have Fallen, No Pity for a Coward" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandName", "Category", "Description", "Image", "Name", "SongsString" },
                values: new object[] { 8, "TOOL", null, "10,000 Days is the fourth studio album by American rock band Tool. The album was released by Tool Dissectional and Volcano Entertainment on April 28, 2006 in parts of Europe, April 29, 2006 in Australia, May 1, 2006 in the United Kingdom, and on May 2, 2006 in North America.", "Images/10000 days.jfif", "10.000 Days", "Vicarious, Jambi, Wings for Marie(Pt1), 10,000 Days(Wings Pt2), The Pot, Lipan Conjuring, Lost Keys(Blame Hoffman), Rosetta Stoned, Intension, Right In Two, Viginti Tres" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}

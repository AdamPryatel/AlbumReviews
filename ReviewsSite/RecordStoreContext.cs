using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class RecordStoreContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }    
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localDb)\\mssqllocaldb; Database= RecordStoreDB_102021; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    Id = 1,
                    Name = "The Black Album",
                    BandName = "Metallica",
                    Description = "Is the fifth studio album by American heavy metal band Metallica, released on August 12, 1991 through Elektra Records.It was recorded in an eight - month span at One on One Recording Studios in Los Angeles.",
                    SongsString = "Enter Sandman, Sad But True, Holier Than Thou, The Unforgiven, Wherever I May Roam, Don't Tread on Me, Through the Never, Nothing Else Matters, Of Wolf and Man, The God That Failed, My Friend of Misery, The Struggle Within" ,
                    Image = "Images/Metallica-Black-Album.jpg"

                }, new Album()
                {
                    Id = 2,
                    Name = "Man on the Moon 3",
                    BandName = "Kid Cudi",
                    Description = "Is the seventh studio album by American rapper Kid Cudi. It was released on December 11, 2020 by Republic Records. It is the final installment of Cudi's Man on the Moon trilogy of albums.",
                    SongsString = "Beautiful Trip, Tequila Shots, Another Day, She Knows This, Dive, Damaged, Heaven On Earth, Show Out, Solo Dolo, Pt. III, Sad People, Elsie's Baby Boy (flashback), Sept. 16, The Void, Lovin' Me, The Pale Moonlight, Rockstar Knights, 4 Da Kidz, Lord I Know",
                    Image = "Images/Man_on_the_Moon_III.jpg"
                }, new Album()
                {
                    Id = 3,
                    Name = "Ready To Die",
                    BandName = "Biggie Smalls",
                    Description = "Ready to Die is the debut studio album by American rapper The Notorious B.I.G., released on September 13, 1994, by Bad Boy Records and Arista Records. The album features productions by Yung Chedder (James Ryan), Bad Boy founder Sean Puffy Combs, Easy Mo Bee, Chucky Thompson, DJ Premier, and Lord Finesse, among others. It was recorded from 1993 to 1994 at The Hit Factory and D&D Studios in New York City",
                    SongsString = "Intro, The What, Unbelievable, Things Done Changed, Juicy, One more chance, Warning, Everyday Struggle, Respect, Suicidal Thoughts, Friend of Me, Gimme the Loot, Machine Gun Funk,Ready To Die, Me & My Bitch, Big Poppa, F*ck Me, Just Playing, Who Shot Ya, Warning, Friend of Mine ",
                    Image = "Images/2nd album.jpg"
                }, new Album()
                {
                    Id = 4,
                    Name = "Requiem",
                    BandName = "Apashe",
                    Description = "Publishied on Febuary 28 2018 Apashe lines one up for the home team as he drops his largest release on Kannibalen Records yet. A conceptual project that combines his usual love of hip-hop-infused bass with the orchestral influences of Mozart, the aptly titled Requiem project brings on the dancefloor heat while also smashing it on the production tip—from recording live instruments in cavernous churches to controlling the mixing and mastering of the EP with his untouchable ear. Expect to hear plenty of the three tracks being dropped alongside label mates Black Tiger Sex Machine as they embark on their otherworldly Ceremony Tour.",
                    SongsString = "Majesty feat. Wasiu (feat. Wasiu), Dies Irae feat. Black Prez (feat. Black Prez), Lacrimosa",
                    Image = "Images/1st album.jpg"
                }, new Album()
                {
                    Id = 5,
                    Name = "Through Being Cool",
                    BandName = "Saves the Day",
                    Description = "Through Being Cool is the second studio album by American rock band Saves the Day, released on November 2, 1999 by Equal Vision. The songs on Through Being Cool were written while the band members attended New York University. The album was recorded in 11 days and represented the band's transition from a melodic hardcore sound to a more pop punk style. It was produced by Steve Evetts at Trax East Recording Studio in South River, New Jersey.",
                    SongsString = "All-Star Me, You Vandal, Shoulder to the Wheel, Rocks Tonic Juice Magic, Holly Hox Forget Me Nots, Third Engine, My Sweet Fracture, The Vast Spoils of America (From the Badlands through the Ocean), The Last Lie I Told, Do You Know What I Love the Most?, Through Being Cool, Banned from the Back Porch",
                    Image = "Images/STD TBC.jpg"
                }, new Album()
                {
                    Id = 6,
                    Name = "Pinkerton",
                    BandName = "Weezer",
                    Description = "Pinkerton is the second studio album by American rock band Weezer, released on September 24, 1996 by DGC Records. After abandoning plans for a rock opera entitled Songs from the Black Hole, Weezer recorded the album between songwriter Rivers Cuomo's terms at Harvard University, where he wrote most of the songs.",
                    SongsString = "Tired of Sex, Getchoo, No Other One, Why Bother?, Across the Sea, The Good Life, El Scorcho, Pink Triangle, Falling for You, Butterfly",
                    Image = "Images/WP.jpg"


                
                }, new Album()
                {
                    Id = 7,
                    Name = "Lugal Ki En",
                    BandName = "Rings of Saturn",
                    Description = "Lugal Ki En is the third album by American deathcore band Rings of Saturn released on October 14, 2014. It was produced by Brette Ciamarra at Studio 344 in Pittsburgh, Pennsylvania and features guest solo work by Rusty Cooley from Day of Reckoning and custom artwork by Mark Cooper of Mind Rape Art, who also created the band's Dingir cover.",
                    SongsString = "Senseless Massacre, Desolate Paradise, Lalassu Xul, Infused, Fractal Intake, Natural Selection, Beckon, Godless  Times, Unsympathetic Intellect, Eviscerate, The Heavens Have Fallen, No Pity for a Coward",
                    Image = "Images/Lugal.jfif"
                },    new Album()
                {
                     Id = 8,
                     Name = "10.000 Days",
                     BandName = "TOOL",
                     Description = "10,000 Days is the fourth studio album by American rock band Tool. The album was released by Tool Dissectional and Volcano Entertainment on April 28, 2006 in parts of Europe, April 29, 2006 in Australia, May 1, 2006 in the United Kingdom, and on May 2, 2006 in North America.",
                     SongsString = "Vicarious, Jambi, Wings for Marie(Pt1), 10,000 Days(Wings Pt2), The Pot, Lipan Conjuring, Lost Keys(Blame Hoffman), Rosetta Stoned, Intension, Right In Two, Viginti Tres",
                     Image = "Images/10000 days.jfif"
                },
                 new Album()
                 {
                     Id = 9,
                     Name = "A Moment Apart",
                     BandName = "Odesza",
                     Description = "A Moment Apart is the third studio album by the American electronic music duo ODESZA, released on 8 September 2017 through Counter, Ninja Tune and the duo's own label, Foreign Family Collective. It is the duo's first album in three years after their second album, In Return, and the first released through Foreign Family Collective.",
                     SongsString = "Intro, A Moment Apart, Higher Ground, Boy, Line of Sight, Late Night, Across the Room, Meridian, Everything at your feet, Just a memory, Divide, Thin Floors and Tall Cielings, La Ciudad, Falls, Show Me, Corners of the Earth",
                     Image = "Images/amap.jfif"
                 },
                 new Album()
                 {
                     Id = 10,
                     Name = "Original Sound Track",
                     BandName = "The Shining",
                     Description = "The Shining is a 1980 psychological horror film produced and directed by Stanley Kubrick and co-written with novelist Diane Johnson. The film is based on Stephen King's 1977 novel of the same name and stars Jack Nicholson, Shelley Duvall, Scatman Crothers, and Danny Lloyd.",
                     SongsString = "The Shining - Main Title, Rocky Mountains, Lontano, Music for Strings Percussion And Celesta, Utrenja (Exerpt), The Awakening Of Jacob, De Natura Sonoris No. 2, Home",
                     Image = "Images/TheShining.jpg"
                 },
                 new Album()
                 {
                     Id = 11,
                     Name = "Hamilton",
                     BandName = "Lin-Manuel Miranda",
                     Description = "Hamilton is the cast album to the 2015 musical Hamilton. The musical is based on the 2004 biography of Alexander Hamilton written by Ron Chernow, with music, lyrics, and book by Lin-Manuel Miranda.",
                     SongsString = "Alexander Hamilton, Aaron Burr Sir, My Shot, The Story Of Tonight, The Schuyler Sisters, Farmer Refuted, You'll Be Back, Right Hand Man, A Winter's Ball , Helpless, Satisfied, The Story of Tonight (Reprise), Wait For It, Stay Alive, Ten Duel Commandments, Meet Me Inside, That Would Be Enough Guns and Ships, History Has Its Eyes On You, Yorktown (The World Turned Upside Down), What Comes Next, Dear Theodosia, Non-Stop",
                     Image = "Images/Hamilton.jpg"
                 },
                 new Album()
                 {
                     Id = 12,
                     Name = "We Like Pizza",
                     BandName = "Pizza Kids",
                     Description = "We Like Pizza by the Pizza Kids from the album We Like Pizza. In this song they highlight many of the wonders of the Italian dish, pizza, They sing about the toppings and the time of day that they like their pizza. It is shown that these children have a strange obsession to the pizza and worship it on a daily basis, in the morning and in the evening. It is a very modern song for it’s time because it underlines many things that children enjoy, such as pizza.",
                     SongsString = "We Like Pizza (Frozen Version), We Like Pizza (Happy Version), We Like Pizza (Waves Version)",
                     Image = "Images/Pizza.jpg"
                 }
                 );

            modelBuilder.Entity<Review>().HasData(
            new Review()
            {
                Id = 1,
                AlbumId = 1,
                Rating = 2,
                Content = "Man this Album blew my mind",
                ReviewerName = "AL Might"

            }, new Review()
            {
                Id = 2,
                AlbumId = 2,
                Rating = 2,
                Content = "Man this is the best version of Cudi",
                ReviewerName = "Mob"
            },
            new Review()
            {
                Id = 3,
                AlbumId = 3,
                Rating = 5,
                Content = "Best of its time",
                ReviewerName = "Karen"
            },
            new Review()
            {
                Id = 4,
                AlbumId = 4,
                Rating = 5,
                Content = "Mightest three song album of It's genre",
                ReviewerName = "Bruce Wayne"
            },
            new Review()
            {
                Id = 5,
                AlbumId = 5,
                Rating = 5,
                Content = "I'm so proud of my boy! He worked so hard and did such a good job!",
                ReviewerName = "Chris Conley's mom"
            },
            new Review()
            {
                Id = 6,
                AlbumId = 5,
                Rating = 1,
                Content = "Lol, you listen to pop punk?",
                ReviewerName = "Jake Ebinger"
            },
            new Review()
            {
                Id = 7,
                AlbumId = 6,
                Rating = 4,
                Content = "I Love this album! I listen to it while I'm cryogenically frozen between Christmas'.",
                ReviewerName = "Michael Buble"
            },
            new Review()
            {
                Id = 8,
                AlbumId = 6,
                Rating = 5,
                Content = "Such a good album. You have to check it out!",
                ReviewerName = "Jeremy Leuenberger"
            },
            new Review()
            {
                Id = 9,
                AlbumId = 6,
                Rating = 5,
                Content = "This was their last good album.",
                ReviewerName = "Every Weezer Fan Ever"
            },
                new Review()
                {
                    Id = 10,
                    AlbumId = 9,
                    Rating = 3,
                    Content = "Hey Carlos, pick an album.",
                    ReviewerName = "Trent"

                },
                new Review()
                    {
                        Id = 11,
                        AlbumId = 9,
                        Rating = 5,
                        Content = "Any album? I like A Moment Apart by Odesza.",
                        ReviewerName = "Carlos Lopez"
                    });
        }
    }
}

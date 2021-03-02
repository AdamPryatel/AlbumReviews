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
                });

            // Add more albums here
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
            });
        }
    }
}

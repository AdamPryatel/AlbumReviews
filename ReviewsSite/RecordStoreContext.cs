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

            });












                // review
                // Id = reviewId
                //context = reviewcontext
                // AlbumId

        }
    }
}

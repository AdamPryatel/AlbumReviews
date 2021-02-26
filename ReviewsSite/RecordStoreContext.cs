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
                    ListofSongs = new List<string> { "Enter Sandman", "Sad But True", "Holier Than Thou", "The Unforgiven", "Wherever I May Roam", "Don't Tread on Me", "Through the Never", "Nothing Else Matters", "Of Wolf and Man", "The God That Failed", "My Friend of Misery", "The Struggle Within" },
                    Image = "Images/Metallica-Black-Album.jpg"

                }, new Album()
                {
                    Id = 2,
                    Name = "Man on the Moon 3",
                    BandName = "Kid Cudi",
                    Description = "Is the seventh studio album by American rapper Kid Cudi. It was released on December 11, 2020 by Republic Records. It is the final installment of Cudi's Man on the Moon trilogy of albums."

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
                AlbumId = 2,
                Rating = 2,
                Content = "Eh, Could I see the manager?",
                ReviewerName = "Karen"

            });












                // review
                // Id = reviewId
                //context = reviewcontext
                // AlbumId

        }
    }
}

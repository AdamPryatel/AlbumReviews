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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localDb)/mssqllocaldb; Databse= UniversityDB_102021; Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString);

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
                    Description = "Is the fifth studio album by American heavy metal band Metallica, released on August 12, 1991 through Elektra Records.It was recorded in an eight - month span at One on One Recording Studios in Los Angeles."
                }, new Album()
                {
                    Id = 2,
                    Name = "Man on the Moon 3",
                    BandName = "Kid Cudi",
                    Description = "Is the seventh studio album by American rapper Kid Cudi. It was released on December 11, 2020 by Republic Records. It is the final installment of Cudi's Man on the Moon trilogy of albums."
                });
                // Add more albums here
        }
    }
}

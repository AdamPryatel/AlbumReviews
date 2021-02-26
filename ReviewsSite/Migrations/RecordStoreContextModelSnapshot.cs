﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(RecordStoreContext))]
    partial class RecordStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("int");

                    b.Property<string>("SongsString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BandName = "Metallica",
                            Description = "Is the fifth studio album by American heavy metal band Metallica, released on August 12, 1991 through Elektra Records.It was recorded in an eight - month span at One on One Recording Studios in Los Angeles.",
                            Image = "Images/Metallica-Black-Album.jpg",
                            Name = "The Black Album",
                            SongsString = "Enter Sandman , Sad But True, Holier Than Thou, The Unforgiven, Wherever I May Roam, Don't Tread on Me, Through the Never, Nothing Else Matters, Of Wolf and Man, The God That Failed, My Friend of Misery, The Struggle Within"
                        },
                        new
                        {
                            Id = 2,
                            BandName = "Kid Cudi",
                            Description = "Is the seventh studio album by American rapper Kid Cudi. It was released on December 11, 2020 by Republic Records. It is the final installment of Cudi's Man on the Moon trilogy of albums.",
                            Name = "Man on the Moon 3"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ReviewDate")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Content = "Man this Album blew my mind",
                            Rating = 2,
                            ReviewDate = 0,
                            ReviewerName = "AL Might"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 2,
                            Content = "Man this is the best version of Cudi",
                            Rating = 2,
                            ReviewDate = 0,
                            ReviewerName = "Mob"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 2,
                            Content = "Eh, Could I see the manager?",
                            Rating = 2,
                            ReviewDate = 0,
                            ReviewerName = "Karen"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Album", b =>
                {
                    b.HasOne("ReviewsSite.Models.Review", null)
                        .WithMany("Albums")
                        .HasForeignKey("ReviewId");
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}

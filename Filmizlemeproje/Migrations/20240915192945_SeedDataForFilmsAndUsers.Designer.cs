﻿// <auto-generated />
using System;
using Filmizlemeproje.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Filmizlemeproje.Migrations
{
    [DbContext(typeof(FilmAppDbContext))]
    [Migration("20240915192945_SeedDataForFilmsAndUsers")]
    partial class SeedDataForFilmsAndUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Filmizlemeproje.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmId");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            FilmId = 1,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(243),
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Director = "Frank Darabont",
                            Genre = "Drama",
                            ReleaseDate = new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            FilmId = 2,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(245),
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Director = "Francis Ford Coppola",
                            Genre = "Crime, Drama",
                            ReleaseDate = new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Godfather"
                        },
                        new
                        {
                            FilmId = 3,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(246),
                            Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                            Director = "Christopher Nolan",
                            Genre = "Action, Crime, Drama",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            FilmId = 4,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(248),
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Director = "Quentin Tarantino",
                            Genre = "Crime, Drama",
                            ReleaseDate = new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pulp Fiction"
                        },
                        new
                        {
                            FilmId = 5,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(249),
                            Description = "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            Director = "Steven Spielberg",
                            Genre = "Biography, Drama, History",
                            ReleaseDate = new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Schindler's List"
                        },
                        new
                        {
                            FilmId = 6,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(250),
                            Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                            Director = "David Fincher",
                            Genre = "Drama",
                            ReleaseDate = new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Fight Club"
                        },
                        new
                        {
                            FilmId = 7,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(251),
                            Description = "The presidencies of Kennedy and Johnson, Vietnam, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75.",
                            Director = "Robert Zemeckis",
                            Genre = "Drama, Romance",
                            ReleaseDate = new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Forrest Gump"
                        },
                        new
                        {
                            FilmId = 8,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(252),
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                            Director = "Christopher Nolan",
                            Genre = "Action, Adventure, Sci-Fi",
                            ReleaseDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            FilmId = 9,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(254),
                            Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                            Director = "The Wachowskis",
                            Genre = "Action, Sci-Fi",
                            ReleaseDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix"
                        },
                        new
                        {
                            FilmId = 10,
                            CreatedAt = new DateTime(2024, 9, 15, 22, 29, 45, 319, DateTimeKind.Local).AddTicks(255),
                            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Director = "Christopher Nolan",
                            Genre = "Adventure, Drama, Sci-Fi",
                            ReleaseDate = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar"
                        });
                });

            modelBuilder.Entity("Filmizlemeproje.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Filmizlemeproje.Models.WatchedFilm", b =>
                {
                    b.Property<int>("WatchedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WatchedId"));

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("WatchedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WatchedId");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("WatchedFilms");
                });

            modelBuilder.Entity("Filmizlemeproje.Models.WatchedFilm", b =>
                {
                    b.HasOne("Filmizlemeproje.Models.Film", "Film")
                        .WithMany("WatchedFilms")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Filmizlemeproje.Models.User", "User")
                        .WithMany("WatchedFilms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Filmizlemeproje.Models.Film", b =>
                {
                    b.Navigation("WatchedFilms");
                });

            modelBuilder.Entity("Filmizlemeproje.Models.User", b =>
                {
                    b.Navigation("WatchedFilms");
                });
#pragma warning restore 612, 618
        }
    }
}

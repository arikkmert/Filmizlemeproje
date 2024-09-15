using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Filmizlemeproje.Migrations
{
    /// <inheritdoc />
    public partial class SeedFilmData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CreatedAt", "Description", "Director", "Genre", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6965), "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Frank Darabont", "Drama", new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { 2, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6967), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Francis Ford Coppola", "Crime, Drama", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 3, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6968), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", "Christopher Nolan", "Action, Crime, Drama", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { 4, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6969), "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Quentin Tarantino", "Crime, Drama", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { 5, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6971), "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", "Steven Spielberg", "Biography, Drama, History", new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler's List" },
                    { 6, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6972), "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", "David Fincher", "Drama", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { 7, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6973), "The presidencies of Kennedy and Johnson, Vietnam, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75.", "Robert Zemeckis", "Drama, Romance", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { 8, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6974), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", "Christopher Nolan", "Action, Adventure, Sci-Fi", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 9, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6975), "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", "The Wachowskis", "Action, Sci-Fi", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { 10, new DateTime(2024, 9, 15, 16, 51, 10, 507, DateTimeKind.Local).AddTicks(6976), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", "Christopher Nolan", "Adventure, Drama, Sci-Fi", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);
        }
    }
}

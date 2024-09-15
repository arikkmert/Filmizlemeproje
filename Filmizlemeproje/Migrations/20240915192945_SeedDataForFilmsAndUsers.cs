using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Filmizlemeproje.Migrations
{
    public partial class SeedDataForFilmsAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Örnek Film Verileri
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Title", "Description", "ReleaseDate", "Genre", "Director", "CreatedAt" },
                values: new object[,]
                {
                    { 1, "Inception", "A thief who steals corporate secrets through the use of dream-sharing technology...", new DateTime(2010, 7, 16), "Action, Adventure, Sci-Fi", "Christopher Nolan", DateTime.Now },
                    { 2, "The Matrix", "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", new DateTime(1999, 3, 31), "Action, Sci-Fi", "Lana Wachowski, Lilly Wachowski", DateTime.Now },
                    { 3, "Interstellar", "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new DateTime(2014, 11, 7), "Adventure, Drama, Sci-Fi", "Christopher Nolan", DateTime.Now },
                    { 4, "The Dark Knight", "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new DateTime(2008, 7, 18), "Action, Crime, Drama", "Christopher Nolan", DateTime.Now },
                    { 5, "Fight Club", "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.", new DateTime(1999, 10, 15), "Drama", "David Fincher", DateTime.Now }
                    // Diğer örnek filmleri buraya ekleyebilirsin
                });

            // Örnek Kullanıcı Verileri
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Username", "Email", "PasswordHash", "CreatedAt" },
                values: new object[,]
                {
                    { 1, "john_doe", "john@example.com", "hashed_password_1", DateTime.Now },
                    { 2, "jane_doe", "jane@example.com", "hashed_password_2", DateTime.Now },
                    { 3, "alice_smith", "alice@example.com", "hashed_password_3", DateTime.Now },
                    { 4, "bob_johnson", "bob@example.com", "hashed_password_4", DateTime.Now }
                    // Diğer örnek kullanıcıları buraya ekleyebilirsin
                });

            // Örnek WatchedFilm Verileri
            migrationBuilder.InsertData(
                table: "WatchedFilms",
                columns: new[] { "WatchedId", "UserId", "FilmId", "WatchedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, DateTime.Now },
                    { 2, 2, 2, DateTime.Now },
                    { 3, 3, 3, DateTime.Now },
                    { 4, 4, 4, DateTime.Now }
                    // Diğer örnek izlenen filmleri buraya ekleyebilirsin
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Verileri geri al
            migrationBuilder.DeleteData(
                table: "WatchedFilms",
                keyColumn: "WatchedId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WatchedFilms",
                keyColumn: "WatchedId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WatchedFilms",
                keyColumn: "WatchedId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WatchedFilms",
                keyColumn: "WatchedId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

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
        }
    }
}

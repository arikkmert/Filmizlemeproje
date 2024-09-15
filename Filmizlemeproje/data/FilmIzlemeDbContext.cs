using Microsoft.EntityFrameworkCore;
using Filmizlemeproje.Models;

namespace Filmizlemeproje.Data
{
    public class FilmAppDbContext : DbContext
    {
        public FilmAppDbContext(DbContextOptions<FilmAppDbContext> options) : base(options) { }

        // Veritabanı tabloları
        public DbSet<User> Users { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<WatchedFilm> WatchedFilms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Film verilerini önceden doldur
            modelBuilder.Entity<Film>().HasData(
                new Film
                {
                    FilmId = 1,
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                    ReleaseDate = new DateTime(1994, 9, 23),
                    Genre = "Drama",
                    Director = "Frank Darabont",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 2,
                    Title = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    ReleaseDate = new DateTime(1972, 3, 24),
                    Genre = "Crime, Drama",
                    Director = "Francis Ford Coppola",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 3,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                    ReleaseDate = new DateTime(2008, 7, 18),
                    Genre = "Action, Crime, Drama",
                    Director = "Christopher Nolan",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 4,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    ReleaseDate = new DateTime(1994, 10, 14),
                    Genre = "Crime, Drama",
                    Director = "Quentin Tarantino",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 5,
                    Title = "Schindler's List",
                    Description = "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                    ReleaseDate = new DateTime(1993, 12, 15),
                    Genre = "Biography, Drama, History",
                    Director = "Steven Spielberg",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 6,
                    Title = "Fight Club",
                    Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
                    ReleaseDate = new DateTime(1999, 10, 15),
                    Genre = "Drama",
                    Director = "David Fincher",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 7,
                    Title = "Forrest Gump",
                    Description = "The presidencies of Kennedy and Johnson, Vietnam, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75.",
                    ReleaseDate = new DateTime(1994, 7, 6),
                    Genre = "Drama, Romance",
                    Director = "Robert Zemeckis",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 8,
                    Title = "Inception",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Genre = "Action, Adventure, Sci-Fi",
                    Director = "Christopher Nolan",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 9,
                    Title = "The Matrix",
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                    ReleaseDate = new DateTime(1999, 3, 31),
                    Genre = "Action, Sci-Fi",
                    Director = "The Wachowskis",
                    CreatedAt = DateTime.Now
                },
                new Film
                {
                    FilmId = 10,
                    Title = "Interstellar",
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    ReleaseDate = new DateTime(2014, 11, 7),
                    Genre = "Adventure, Drama, Sci-Fi",
                    Director = "Christopher Nolan",
                    CreatedAt = DateTime.Now
                }
            );

            // WatchedFilm varlığını yapılandırma
            modelBuilder.Entity<WatchedFilm>()
                .HasKey(wf => wf.WatchedId); // Birincil anahtarı yapılandırın

            modelBuilder.Entity<WatchedFilm>()
                .HasOne(wf => wf.User)
                .WithMany(u => u.WatchedFilms)
                .HasForeignKey(wf => wf.UserId); // User ile ilişkiyi yapılandırın

            modelBuilder.Entity<WatchedFilm>()
                .HasOne(wf => wf.Film)
                .WithMany(f => f.WatchedFilms)
                .HasForeignKey(wf => wf.FilmId); // Film ile ilişkiyi yapılandırın

            base.OnModelCreating(modelBuilder);
        }
    }
}

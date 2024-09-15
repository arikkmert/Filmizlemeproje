namespace Filmizlemeproje.Models
{
    public class WatchedFilm
    {
        public int WatchedId { get; set; } // Primary Key
        public int UserId { get; set; } // Foreign Key - User Tablosu
        public User User { get; set; } // User ile ilişki
        public int FilmId { get; set; } // Foreign Key - Film Tablosu
        public Film Film { get; set; } // Film ile ilişki
        public DateTime WatchedDate { get; set; } = DateTime.Now; // İzlenme Tarihi
    }
}

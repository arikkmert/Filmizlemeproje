namespace Filmizlemeproje.Models
{
    public class Film
    {
        public int FilmId { get; set; } // Primary Key
        public string Title { get; set; } // Film Başlığı
        public string Description { get; set; } // Film Açıklaması
        public DateTime? ReleaseDate { get; set; } // Yayınlanma Tarihi
        public string Genre { get; set; } // Tür
        public string Director { get; set; } // Yönetmen
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Eklenme Tarihi
        public ICollection<WatchedFilm> WatchedFilms { get; set; } // İzlenen Filmler
    }
}

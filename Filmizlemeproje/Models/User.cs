namespace Filmizlemeproje.Models
{
    public class User
    {
        public int UserId { get; set; } // Primary Key
        public string Username { get; set; } // Kullanıcı Adı
        public string Email { get; set; } // E-posta
        public string PasswordHash { get; set; } // Şifre Hash'i
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Eklenme Tarihi
        public ICollection<WatchedFilm> WatchedFilms { get; set; } // İzlenen Filmler
    }
}

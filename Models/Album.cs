using System.ComponentModel.DataAnnotations;

namespace MusicStoreOrnek.Models
{
    public class Album
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double ListPrice { get; set; }
        //public string ImagePath { get; set; }
        //public int GenreId { get; set; }
        //public string Title { get; set; }
        [Key]
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}

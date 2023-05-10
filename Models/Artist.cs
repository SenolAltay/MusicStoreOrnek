using System.ComponentModel.DataAnnotations;

namespace MusicStoreOrnek.Models
{
    //müzik albümlerinin sanatçılarını tutacak class
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

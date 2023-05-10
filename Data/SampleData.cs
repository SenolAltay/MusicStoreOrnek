using MusicStoreOrnek.Models;

namespace MusicStoreOrnek.Data
{
    public class SampleData
    {
        private readonly MusicStoreContext _context;

        public SampleData(MusicStoreContext context)
        {
            _context = context;
        }


        //tur tablosuna kayıt ekleyecek metot.
        public void AddGenres()
        {
            if (_context.Genres.ToList().Count == 0)
            {
                //kayıt ekleme
                List<Genre> genres = new List<Genre>()
            {
                new Genre(){  Name="Jazz"},
                new Genre(){  Name="Pop"},
                new Genre(){  Name="Rock"}
            };

                foreach (var item in genres)
                {
                    _context.Genres.Add(item);
                    _context.SaveChanges();
                }
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MusicStoreOrnek.Data;
using MusicStoreOrnek.Models;
using System.Web;

namespace MusicStoreOrnek.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreContext context;

        public StoreController(MusicStoreContext context)
        {
            this.context = context;
        }


        // /Store/ : store/Index metodunu çağırır.
        //public string Index()
        //{
        //    return "Hello from Store.Index()";
        //}

        public IActionResult Index()
        {
            var muzikTurleri = context.Genres.ToList();
            return View(muzikTurleri);
        }



        //
        // GET: /Store/Browse
        //public string Browse()
        //{
        //    return "Hello from Store.Browse()";
        //}
        // GET: /Store/Browse?genre=Disco
        //public string Browse(string genre)
        //{
        //    string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "
        //+ genre);

        //    return message;
        //}

        //müzik albümlerini türe göre aramak istersek bu metot kullanılacak
        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }



        //
        // GET: /Store/Details
        //public string Details()
        //{
        //    return "Hello from Store.Details()";
        //}

        //Store/Details?id=3 .... burada id değerini 3 olarak alır.
        //not: eğer değişkenin adı id ise bu durumda Store/Details/3 dersek de çalışır 
        //public string Details(int id)
        //{
        //    string message = "Store.Details, ID = " + id;

        //    return message;
        //}


        //bir müzik albümüne tıklanınca onun detay bilgisini getirecek metot.
        public ActionResult Details(int id)
        {
            var album = new Album { Title = "album başlıgı yazılacak " + id };
            return View(album);
        }



        //değişken adı id değilse ?değişkenadi=deger şeklinde çağırmak gerekir
        //public string Details(int idim)
        //{
        //    string message = "Store.Details, ID = " + idim;

        //    return message;
        //}


        //not:
        //bir metoda arama cubugundan parametre göndermenin yolu ?degiskenAdi=degeri şeklindedir.

        //eğer değişken adınnı büyük yazarsak  ... ALIR
        //fakat değişken adını yanlış yazarsak ... ALMAZ

    }
}

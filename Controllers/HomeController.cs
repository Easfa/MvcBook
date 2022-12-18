using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcBook.Models;
using MvcWorkspace.Data;
using MvcWorkspace.Models;
using System.Linq;

namespace MvcBook.Controllers;

public class HomeController : Controller
{

    //start here
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // public readonly AppDbContext _db;

    // public HomeController(AppDbContext db)
    // {
    //     _db = db;
    // }

    [HttpGet]
    public IActionResult Index()
    {
        //Veritabanından veriler buraya gelicek 
        //Dbsetadi ve DataModelAdı aşağıda yorum satırında bulunan koda eklenecek ve dummy datalar silinecek.

        //List<DenemeData> books = _db.(DbSetName);

        //Dummy Datalar
        var books = new List<DenemeData>
    {
       new DenemeData{ Id=1, Adi="Deneme1", SayfaSayisi=25},
       new DenemeData{ Id=2, Adi="Deneme2", SayfaSayisi=20},
       new DenemeData{ Id=3, Adi="Deneme3", SayfaSayisi=30},
       new DenemeData{ Id=4, Adi="Deneme4", SayfaSayisi=300}
    };
        //RASTGELE 3 KİTAP LİSTELEME İŞLEMLERİ
        var r = new Random();
        //DenemeData gerçek data ile değiştirilecek
        var ThreeRandomBookList = new List<DenemeData>();
        ThreeRandomBookList = books.OrderBy(x => r.Next()).Take(3).ToList();
        //RASTGELE 3 KİTAP LİSTELEME İŞLEMLERİ BİTİŞ 
        return View(ThreeRandomBookList);
    }


    public IActionResult UserLogin(KullaniciDenemeData userinfo)
    {
        //Dbsetadi ve DataModelAdı aşağıda yorum satırında bulunan koda eklenecek ve dummy datalar silinecek.
        //List<KullaniciDenemeData> userData = _db.(DbSetName);
        //Dummy Datalar
        var userData = new List<KullaniciDenemeData>
    {
       new KullaniciDenemeData{username="deneme", userpass="0000"},
       new KullaniciDenemeData{username="deneme1", userpass="1111"},
       new KullaniciDenemeData{username="deneme2", userpass="2222"},
    };

    //Girilen kullanıcı adı ve şifre veri tabanında bulunan değer ile karşılaştırılıyor
        var user = userData.FirstOrDefault(x => x.username == userinfo.username && x.userpass == userinfo.userpass);
        if (user != null)
        {
            return RedirectToAction("Index");
        }
        else
        {
            return View();
        }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

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


    public IActionResult Index()
    {
        //Dummy Datalar
        //Veritabanından veriler buraya gelicek ama oluşturulan liste ismi değişmeyecek
        var books = new List<DenemeData>
    {
       new DenemeData{ Id=1, Adi="Deneme1", SayfaSayisi=25},
       new DenemeData{ Id=2, Adi="Deneme2", SayfaSayisi=20},
       new DenemeData{ Id=3, Adi="Deneme3", SayfaSayisi=30},
       new DenemeData{ Id=4, Adi="Deneme4", SayfaSayisi=300}
    };
        //Rastgele 3 kitap listeleme İşlemleri
        var r = new Random();
        var ThreeRandomBookList = new List<DenemeData>();
        ThreeRandomBookList = books.OrderBy(x => r.Next()).Take(3).ToList();
        //Rastgele 3 kitap listeleme İşlemleri Bitiş 
        return View(ThreeRandomBookList);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcBook.Models;
using MvcWorkspace.Data;
namespace MvcBook.Controllers;

public class HomeController : Controller
{
    //start here
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }


    /*[HttpGet]
    public IActionResult Index()
    {
        //RASTGELE 3 KİTAP LİSTELEME İŞLEMLERİ
        var r = new Random();
        //DenemeData gerçek data ile değiştirilecek
        var ThreeRandomBookList = new List<DenemeData>();
        ThreeRandomBookList = _db.books1.OrderBy(x => r.Next()).Take(3).ToList();
        //RASTGELE 3 KİTAP LİSTELEME İŞLEMLERİ BİTİŞ 
        return View(ThreeRandomBookList);
    }
    
    public IActionResult UserLogin(KullaniciDenemeData userinfo)
    {
        var user = _db.userData.FirstOrDefault(x => x.username == userinfo.username && x.userpass == userinfo.userpass);
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
    }*/
}

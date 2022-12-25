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


    [HttpGet]
    public IActionResult Index()
    {
        //RASTGELE 3 KİTAP LİSTELEME İŞLEMLERİ
        var r = new Random();
        //DenemeData gerçek data ile değiştirilecek
        var Books = _db.Books.Select(x => x).ToList();
        List<Books> ThreeRandomBookList= new List<Books>();

        for(int i = 0; i <= 2; i++) 
        {
            ThreeRandomBookList.Add(Books[r.Next(Books.Count())]);
        }
        //RASTGELE 3 KİTAP LİSTELEME İŞLEMLERİ BİTİŞ 
        return View(ThreeRandomBookList);
    }
    
    public IActionResult UserLogin(Users userinfo)
    {
        var user = _db.Users.FirstOrDefault(x => x.U_Name == userinfo.U_Name && x.U_Password == userinfo.U_Password);
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

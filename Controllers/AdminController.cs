using Microsoft.AspNetCore.Mvc;
using MvcBook.Models;
using MvcWorkspace.Data;

namespace MvcBook.Controllers
{
    public class AdminController : Controller
    {
        public readonly AppDbContext _db;
        public AdminController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(Admin admininfo)
        {

            //Girilen kullanıcı adı ve şifre veri tabanında bulunan değer ile karşılaştırılıyor
            var user = _db.adminData.FirstOrDefault(x => x.adminname == admininfo.adminname && x.adminpass == admininfo.adminpass);
            if (user != null)
            {
                return RedirectToAction("BookAdd");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult BookAdd()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult BookAdd(Books b)
        {
            _db.books.Add(b);
            return View();
        }

    }
}
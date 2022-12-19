using Microsoft.AspNetCore.Mvc;
using MvcWorkspace.Data;
using MvcWorkspace.Models;

namespace MvcBook.Controllers
{
    public class BooksController : Controller
    {
        // public readonly AppDbContext _db;

        // public BooksController(AppDbContext db)
        // {
        //     _db = db;
        // }

        public IActionResult Index()
        {
            //Dbsetadi ve DataModelAdı aşağıda yorum satırında bulunan koda eklenecek 
            //List<DenemeData> books = _db.(DbSetName);
            var books = new List<DenemeData>
            {
            new DenemeData{ Id=1, Adi="Deneme1", SayfaSayisi=25},
            new DenemeData{ Id=2, Adi="Deneme2", SayfaSayisi=20},
            new DenemeData{ Id=3, Adi="Deneme3", SayfaSayisi=30},
            new DenemeData{ Id=4, Adi="Deneme4", SayfaSayisi=300}
            };
            return View(books.ToList());
        }
        public IActionResult BooksInfo()
        { 
            return View();
        }
    }
}

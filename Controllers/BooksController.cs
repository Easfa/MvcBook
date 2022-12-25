using Microsoft.AspNetCore.Mvc;
using MvcBook.Models;
using MvcWorkspace.Data;

namespace MvcBook.Controllers
{
    public class BooksController : Controller
    {
        public readonly AppDbContext _db;
        public BooksController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //Dbsettn gelen books yazdırılıcak
            return View(_db.Books.ToList());
        }
        [HttpGet]
        public IActionResult BookInfo(int id)
        {
            int a =id;
            return View();
        }
        [HttpPost]
        public IActionResult BookInfo()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CommentAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CommentAdd(Commentaries c)
        {
            _db.Commentaries.Add(c);
            var a = _db.Commentaries;
            _db.SaveChanges();
            return View();
        }
        [HttpGet]
        
        public IActionResult CommentUpdate()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CommentUpdate(Commentaries c)
        {
            var comment = _db.Commentaries.Where(i => i.C_Id == c.C_Id).FirstOrDefault();
            if (comment != null)
            {
                _db.Update(c);
            }
            _db.SaveChanges();

            return View();

        }
        public IActionResult CommentDelete(int c)
        {
            var comment = _db.Commentaries.Where(i => i.C_Id == c).FirstOrDefault();
            if (comment == null)
            {
                return NotFound();
            }
            _db.Commentaries.Remove(comment);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}

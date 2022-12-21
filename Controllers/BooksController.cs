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
        public IActionResult BookInfo(int id)
        {
            var comments = new List<Commentaries>
            {
              new Commentaries{C_Id= 1, B_Id= 2, C_Head="", C_Body=""},
              new Commentaries{C_Id= 2, B_Id= 3, C_Head="", C_Body=""},
              new Commentaries{C_Id= 3, B_Id= 1, C_Head="", C_Body="1 yorum"},
              new Commentaries{C_Id= 4, B_Id= 3, C_Head="", C_Body=""},
              new Commentaries{C_Id= 5, B_Id= 1, C_Head="", C_Body=""},
              new Commentaries{C_Id= 6, B_Id= 1, C_Head="", C_Body="1yorkum"},
              new Commentaries{C_Id= 7, B_Id= 2, C_Head="", C_Body="fdjkd"}
            };
            var books = new List<Books>
            {
            new Books{ B_Id=1, B_Name="Deneme1", B_Page=25},
            new Books{ B_Id=2, B_Name="Deneme2", B_Page=20},
            new Books{ B_Id=3, B_Name="Deneme3", B_Page=30},
            new Books{ B_Id=4, B_Name="Deneme4", B_Page=300}
            };

            //Bütün tablo elemanlarını tekrardan yazmak gerekiyor. bütün tabloyu yazdır dediğimde çalışmıyor?
            ViewBag.BookJoinComment = comments.Join(
                                books,
                                comments => comments.B_Id,
                                books => books.B_Id,
                                (comments, books) => new
                                {
                                    commentsbody = comments.C_Body,
                                    booksid = books.B_Id,
                                    bookname = books.B_Name
                                }).Where(x => x.booksid == id).ToList();
            return View();

        }
    }
}

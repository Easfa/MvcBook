using Microsoft.AspNetCore.Mvc;
using MvcBook.Models;

namespace MvcBook.Controllers
{
    public class AdminController : Controller
    {
        
        public IActionResult Index(Admin admininfo)
        {
            //Dbsetadi ve DataModelAdı aşağıda yorum satırında bulunan koda eklenecek ve dummy datalar silinecek.
            //List<KullaniciDenemeData> userData = _db.(DbSetName);
            //Dummy Datalar
            var userData = new List<Admin>
            {
            new Admin{adminname="deneme", adminpass="0000"},
            new Admin{adminname="deneme1", adminpass="1111"},
            new Admin{adminname="deneme2", adminpass="2222"},
            };

            //Girilen kullanıcı adı ve şifre veri tabanında bulunan değer ile karşılaştırılıyor
            var user = userData.FirstOrDefault(x => x.adminname == admininfo.adminname && x.adminpass == admininfo.adminpass);
            if (user != null)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

    }
}
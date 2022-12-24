using MvcBook.Controllers;

namespace MvcBook.Models.ViewModels
{
    internal class BooksVM
    {
       public IEnumerable<Books> Books1 { get; set; }
       public IEnumerable<Commentaries> Commentaries1 { get; set; }
    }
}
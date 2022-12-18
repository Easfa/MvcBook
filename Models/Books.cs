
using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Books
    {
        [Key]
        [Required]
        public virtual Users B_Id { get; set; }
        [Required]
        public string B_Name { get; set; }
        public string B_Author { get; set; }
        public string B_Page { get; set; }
    }
}


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Books
    {
        [Key]
        [Required]
        [DisplayName("BookID")]
        public virtual Users B_Id { get; set; }
        [Required]
        [DisplayName("Book Name")]
        public string B_Name { get; set; }
        [DisplayName("Author")]
        public string B_Author { get; set; }
        [Display("Page Numbers")]
        public string B_Page { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return B_Id + " - " + B_Name + " - " + B_Author + " - " + B_Page;
        }
        public string ToString()
        {

        }
    }
}

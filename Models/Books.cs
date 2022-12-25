
using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Books
    {
        private List<Books> Book { get; set; }
        [Key]
        public int B_Id { get; set; }
        [Required]
        public string B_Name { get; set; }
        public string B_Coantents { get; set; }
        public string B_Author { get; set; }
        public string B_Page { get; set; }
        public string ImgTitle { get; set; }

        public override string ToString()
        {
            return B_Id + " - " + B_Name + " - " + B_Author + " - " + B_Page;
        }

        public string HtmlGenerator()
        {
            string ret = @"<table><th><tr><td>id</td><td>title</td><td>rating</td><td>genre</td><td>duration</td></tr></th><tbody>";

            foreach (var k in Book)
            {
                ret += @"<tr>";
                ret += @"<td>" + k.B_Id.ToString() + @"</td>";
                ret += @"<td>" + k.B_Name + @"</td>";
                ret += @"<td>" + k.B_Author + @"</td>";
                ret += @"<td>" + k.B_Page + @"</td>";
                ret += @"</tr>";
            }
            ret += @"</tbody></table>";

            return ret;
        }

    }
}

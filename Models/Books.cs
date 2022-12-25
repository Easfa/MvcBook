﻿
using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Books
    {
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

        public string HtmlGenerator(Books book, string tag)
        {
            string ret = "";
            ret += "<" + tag + ">";
                ret += @"<td>" + book.B_Id.ToString() + @"</td>";
                ret += @"<td>" + book.B_Name + @"</td>";
                ret += @"<td>" + book.B_Author + @"</td>";
                ret += @"<td>" + book.B_Page + @"</td>";
            return ret;
        }

    }
}

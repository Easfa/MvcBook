using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBook.Models
{
    public class Commentaries
    {
        [Key]
        [Required]
        public int C_Id { get; set; }

        [ForeignKey("Users")]
        public int U_Id { get; set; }
        [ValidateNever]
        public Users Users { get; set; }


        [ForeignKey("Books")]
        public int B_Id { get; set; }
        [ValidateNever]
        public Books Books { get; set; }

        public string C_Head { get; set; }
        public string C_Body { get; set; }
        [Required]
        public DateTime C_Date { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return C_Head + " - " + C_Body + " - " + C_Date + " - ";
        }
    }
}

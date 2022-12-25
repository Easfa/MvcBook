using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBook.Models
{
    public class Commentaries
    {
        [Key]
        [Required]
        public int C_Id { get; set; }
        [InverseProperty("B_Id")]  //Test edilecek...
        [Required]
        public virtual ICollection<Books> B_Id { get; set; }
        [InverseProperty("U_Id")]  //Test edilecek...
        [Required]
        public virtual ICollection<Users> U_Id { get; set; }
        public string C_Head { get; set; }
        public string C_Body { get; set; }
        [Required]
        public DateTime C_Date { get; set; }

        public override string ToString()
        {
            return C_Head + " - " + C_Body + " - " + C_Date + " - ";
        }
    }
}

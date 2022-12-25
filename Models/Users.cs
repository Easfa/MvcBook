
using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Users
    {
        [Key]
        public int U_Id { get; set; }
        [Required]
        public string U_Name { get; set; }
        [Required]
        public string U_LastName { get; set; }
        [Required]
        [MaxLength(8, ErrorMessage = "Password must be between 5-8 characters."), MinLength(5)]
        public string U_Password { get; set; }
        [Required]
        public string U_Mail { get; set; }
        public DateTime? U_Bday { get; set; }
        public DateTime U_SignupDay { get; set; } = DateTime.Now;
        public bool Is_Admin { get; set; } // Kontrol edilecek?
    }
}


using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Users
    {
        [Key]
        [Required]
        public virtual Users U_Id { get; set; }
        [Required]
        public string U_Name { get; set; }
        [Required]
        public string U_LastName { get; set; }
        [Required]
        [MaxLength(8, ErrorMessage = "Password must be between 5-8 characters."), MinLength(5)]
        public string U_Password { get; set; }
        [Required]
        public string U_Mail { get; set; }
        public string U_Bday { get; set; }
        public string U_SignupDay { get; set; }
        public bool Is_Admin { get; set; } // Kontrol edilecek?
    }
}

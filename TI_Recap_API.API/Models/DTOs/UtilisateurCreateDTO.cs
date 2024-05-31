using System.ComponentModel.DataAnnotations;

namespace TI_Recap_API.API.Models.DTOs
{
    public class UtilisateurCreateDTO
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$", ErrorMessage = "Le mot de passe doit contenir 1 Maj, 1 Min, 1 chiffre, 1 char spécial")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string PasswordCheck { get; set; }
    }
}

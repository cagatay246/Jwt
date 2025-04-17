using System.ComponentModel.DataAnnotations;

namespace JwtAuthProject.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; } // Normalde hashlenmelidir!
    }
}
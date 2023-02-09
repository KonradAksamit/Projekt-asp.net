using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dziekanat.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nazwa użytkownika")]
        [StringLength(20, ErrorMessage = "Nazwa użytkownika może zawierać maksymalnie 20 znaków")]
        [Index(IsUnique = true)]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Hasło")]
        [StringLength(20, ErrorMessage = "Hasło może zawierać maksymalnie 20 znaków")]
        public string Password { get; set; }
    }
}

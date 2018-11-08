using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Le {0} doit avoir au moins {2} et au maximum {1} charactères.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmer Mot de passe")]
        [Compare("Password", ErrorMessage = "le mot de passe et sa confirmation de correspondent pas.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "GamerTag")]
        public string UserName { get; set; }

    }
}

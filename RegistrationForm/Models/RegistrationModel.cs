using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid length")]
        [Display]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Invalid length")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Email address confirmation is required")]
        [EmailAddress]
        [Compare("EmailAddress")]
        public string ConfirmAddress { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Invalid length")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Password confirmation is required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Birth date is required")]
        public DateTime BirthDate{ get; set; }

        public int Age { get; set; }
    }
}

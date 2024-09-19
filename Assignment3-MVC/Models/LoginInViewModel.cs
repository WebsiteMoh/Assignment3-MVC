using System.ComponentModel.DataAnnotations;

namespace Assignment3_MVC.Models
{
    public class LoginInViewModel
    {
        [Required(ErrorMessage = "Email is required")]

        public String Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
         public String Password { get; set; }

    }
}

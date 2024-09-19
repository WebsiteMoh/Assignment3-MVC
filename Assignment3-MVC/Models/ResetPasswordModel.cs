using System.ComponentModel.DataAnnotations;

namespace Assignment3_MVC.Models
{
    public class ResetPasswordModel
    {
        [Required(ErrorMessage = "Email is required")]

        public String Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Confirm Password is not matching your password")]
        public String ConfirmedPassword { get; set; }

        public String Token { get; set; }   

    }
}

using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Assignment3_MVC.Models
{
    public class SignUpViewModel 
    {
        [Required(ErrorMessage ="First Name is required")]
      public String Fname { get; set; }
        [Required(ErrorMessage = "Last Name is required")]

        public String Lname { get; set; }
        [Required(ErrorMessage = "Email is required")]

        public String Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public String Password { get; set; }
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password",ErrorMessage ="Confirm Password is not matching your password")]
        public String ConfirmedPassword { get; set; }

    }
}

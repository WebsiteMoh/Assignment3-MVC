using Assignment3_MVC.Models;
using Company.data;
using Company.Services.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUsers> _UserManger;
        private readonly SignInManager<ApplicationUsers> _SigninManger;

        public AccountController(UserManager<ApplicationUsers> co, SignInManager<ApplicationUsers> signinManger)
        {
            _UserManger = co;
            _SigninManger = signinManger;
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel input)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUsers
                {
                    UserName= input.Email.Split("@")[0],
                    Email = input.Email,
                    FName = input.Fname,
                    Lname = input.Lname
                   



                };
                var result = await _UserManger.CreateAsync(user, input.Password);
                if (result.Succeeded)
                return RedirectToAction("SignIn");
              
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

            }
             return View();

            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginInViewModel input)
        {
            if (ModelState.IsValid)
            {
                var user = await _UserManger.FindByEmailAsync(input.Email);
                if(user is not null)
                {
                    if(await _UserManger.CheckPasswordAsync(user, input.Password))
                    {
                        var result=await _SigninManger.PasswordSignInAsync(user, input.Password,true,true);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                ModelState.AddModelError("", "Incorrect Email or Password");
            }
            return View(input);


        }
        public new async Task<IActionResult> Signout()
        {
            await _SigninManger.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordModel input)
        {
            var user = await _UserManger.FindByEmailAsync(input.Email);
            if (ModelState.IsValid)
            {
                if(user is not null)
                {
                    var token = await _UserManger.GeneratePasswordResetTokenAsync(user);
                    var url = Url.Action("ResetPassword", "Account", new { Email = input.Email, Token = token });
                    EmailSettings Email = new EmailSettings()
                    {
                        Body = url,
                        Subject = "Reset Password",
                        To = input.Email
                    };
                    EmailSettings.SendEmail(Email);
                    return RedirectToAction(nameof(CheckYourInbox));
                }
            }
            return View(input);
        }
        public IActionResult CheckYourInbox()
        {
            return View();
        }
        public IActionResult ResetPassword(String Email,String Token)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel input)
        {
            if(ModelState.IsValid)
            {
                var user = await _UserManger.FindByEmailAsync(input.Email);
                if(user is not null)
                {
                    var result = await _UserManger.ResetPasswordAsync(user, input.Token, input.Password);
                    if(result.Succeeded)
                        return RedirectToAction(nameof(Login));
                }
            }
            return View();

        }
    }
}

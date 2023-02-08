using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAISTGolf_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BAISTGolf_Project.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel (SignInManager<IdentityUser> signInManager)
        {

        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> onPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
               var identityResult =  await signInManager.PasswordSignInAsync(Model.Email, Model.Passoword, Model.RememberMe, false);
                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }
                ModelState.AddModelError("", "Username or password incorrect");
            }
            return Page();
        }
    }
}

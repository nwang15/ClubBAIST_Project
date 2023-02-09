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
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Login Model { get; set; }

        public LoginModel (UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
               var identityRes =  await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if (identityRes.Succeeded)
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

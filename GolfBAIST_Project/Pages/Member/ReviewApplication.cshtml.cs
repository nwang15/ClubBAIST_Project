using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.Member
{
    public class ReviewApplicationModel : PageModel
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public List<MemberApplication> MemberApplications { get; set; }
        // public MemberApplication MemberApplication { get; set; }

        [BindProperty]
        public string userId { get; set; }
        public ReviewApplicationModel(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            
            this._applicationDbContext = applicationDbContext;
            this._userManager = userManager;
        }
        public void OnGet()
        {
            userId = _userManager.GetUserId(HttpContext.User);
            MemberApplications =  _applicationDbContext.MemberApplications.Where(x => x.Id.Equals(userId)).ToList();
        }
    }
}

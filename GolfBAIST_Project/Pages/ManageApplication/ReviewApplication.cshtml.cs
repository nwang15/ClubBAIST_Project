using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace GolfBAIST_Project.Pages.ManageApplication
{
    public class ReviewApplicationModel : PageModel
    {
        private readonly ApplicationDbContext applicationDbContext;
        public List<MemberApplication> memberApplications { get; set; }

        public ReviewApplicationModel(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public void OnGet()
        {
           var memberApplicationInfo = applicationDbContext.MemberApplications.ToList();
        }
    }
}

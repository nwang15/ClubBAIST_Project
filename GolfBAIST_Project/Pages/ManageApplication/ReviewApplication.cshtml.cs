using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task OnGet()
        {
           var memberApplicationInfo = applicationDbContext.MemberApplications.ToListAsync();
        }
    }
}

using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
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
        private readonly IMemberApplicationRepository memberApplicationRepository;

        public List<MemberApplication> memberApplications { get; set; }

        public ReviewApplicationModel(IMemberApplicationRepository memberApplicationRepository)
        {
            this.memberApplicationRepository = memberApplicationRepository;
        }
        public async Task OnGet()
        {
            memberApplications = (await memberApplicationRepository.GetAllAsync())?.ToList();
        }
    }
}

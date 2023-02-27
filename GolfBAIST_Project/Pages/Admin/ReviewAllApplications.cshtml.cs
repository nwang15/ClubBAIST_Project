using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.Admin
{
    public class ReviewAllApplicationsModel : PageModel
    {
        private readonly IMemberApplicationRepository memberApplicationRepository;

        public List<MemberApplication> MemberApplications { get; set; }

        public ReviewAllApplicationsModel(IMemberApplicationRepository memberApplicationRepository)
        {
            this.memberApplicationRepository = memberApplicationRepository;
        }
        public async Task OnGet()
        {
            MemberApplications = (await memberApplicationRepository.GetAllAsync())?.ToList();
        }
    }
}

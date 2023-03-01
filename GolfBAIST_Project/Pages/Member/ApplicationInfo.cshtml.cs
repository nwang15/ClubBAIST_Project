using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.Member
{
    public class ApplicationInfoModel : PageModel
    {
        private readonly IMemberApplicationRepository _memberApplicationRepository;

        [BindProperty]
        public MemberApplication MemberApplications { get; set; }
        public ApplicationInfoModel(IMemberApplicationRepository memberApplicationRepository)
        {
            this._memberApplicationRepository = memberApplicationRepository;
        }
        public async Task OnGet(int applicationId)
        {
            MemberApplications = await _memberApplicationRepository.GetAsync(applicationId);
        }
        public async Task<IActionResult> OnPost()
        {
            var deleted = await _memberApplicationRepository.DeleteAsync(MemberApplications.ApplicationId);

            if (deleted)
            {
                return RedirectToPage("/ManagerApplication/ReviewApplication");
            }
            return Page();
        }
    }
}

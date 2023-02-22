using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.ManageApplication
{
    public class EditApplicationModel : PageModel
    {
        private readonly IMemberApplicationRepository memberApplicationRepository;

        [BindProperty]
        public MemberApplication MemberApplications { get; set; }

        public EditApplicationModel(IMemberApplicationRepository memberApplicationRepository)
        {
            this.memberApplicationRepository = memberApplicationRepository;
        }

        public async Task OnGet(int applicationId)
        {
            MemberApplications = await memberApplicationRepository.GetAsync(applicationId);
        
        }

        public async Task<IActionResult> OnPostEdit()
        {
            await memberApplicationRepository.UpdateAsync(MemberApplications);
            ViewData["MessageDescription"] = "Record was successfully saved!";

            return Page();
        }


        public async Task<IActionResult> OnPostDelete()
        {
           var deleted = await memberApplicationRepository.DeleteAsync(MemberApplications.ApplicationId);

            if (deleted)
            {
                return RedirectToPage("/ManagerApplication/ReviewApplication");
            } 
            return Page();
        }
    }
}

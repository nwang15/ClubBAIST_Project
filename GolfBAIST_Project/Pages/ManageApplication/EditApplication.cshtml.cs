using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.ManageApplication
{
    public class EditApplicationModel : PageModel
    {
        private readonly ApplicationDbContext applicationDbContext;

        [BindProperty]
        public MemberApplication memberApplications { get; set; }

        public EditApplicationModel(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task OnGet(int applicationId)
        {
             memberApplications = await applicationDbContext.MemberApplications.FindAsync(applicationId);
        
        }

        public async Task<IActionResult> OnPostEdit()
        {
            var existingApplication = await applicationDbContext.MemberApplications.FindAsync(memberApplications.ApplicationId);

            if (existingApplication != null)
            {
                existingApplication.MembershipType = memberApplications.MembershipType;
                existingApplication.MemberFirstName = memberApplications.MemberFirstName;
                existingApplication.MemberLastName = memberApplications.MemberLastName;
                existingApplication.MemberAddress = memberApplications.MemberAddress;
                existingApplication.MemberCity = memberApplications.MemberCity;
                existingApplication.MemberProvince = memberApplications.MemberProvince;
                existingApplication.MemberPostalCode = memberApplications.MemberPostalCode;
                existingApplication.MemberDOB = memberApplications.MemberDOB;
                existingApplication.MemberPhoneNumber = memberApplications.MemberPhoneNumber;
                existingApplication.MemberEmail = memberApplications.MemberEmail;
                existingApplication.CompanyName = memberApplications.CompanyName;
                existingApplication.Occupation = memberApplications.Occupation;
                existingApplication.CompanyAddress = memberApplications.CompanyAddress;
                existingApplication.CompanyCity = memberApplications.CompanyCity;
                existingApplication.CompanyProvince = memberApplications.CompanyProvince;
                existingApplication.CompanyPostalCode = memberApplications.CompanyPostalCode;
                existingApplication.CompanyPhoneNumber = memberApplications.CompanyPhoneNumber;
                existingApplication.MemberSignature = memberApplications.MemberSignature;
                existingApplication.MemberSignDate = memberApplications.MemberSignDate;
                existingApplication.FirstShareholderFullName = memberApplications.FirstShareholderFullName;
                existingApplication.SecondShareholderFullName = memberApplications.SecondShareholderFullName;
                existingApplication.FirstShareholderSignDate = memberApplications.FirstShareholderSignDate;
                existingApplication.SecondShareholderSignDate = memberApplications.SecondShareholderSignDate;
            }

            await applicationDbContext.SaveChangesAsync();
            return RedirectToPage("/ManagerApplication/ReviewApplication");
        }


        public async Task<IActionResult> OnPostDelete()
        {
            var existingApplication = await applicationDbContext.MemberApplications.FindAsync(memberApplications.ApplicationId);

            if (existingApplication !=null)
            {
                applicationDbContext.MemberApplications.Remove(existingApplication);
                await applicationDbContext.SaveChangesAsync();

                return RedirectToPage("/ManagerApplication/ReviewApplication");
            }

            return Page();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Models.ViewModels;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.Member
{
    public class SubmitApplicationModel : PageModel
    {


        private readonly IMemberApplicationRepository memberApplicationRepository;

        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public AddApplication AddApplicationRequest { get; set; }

        [BindProperty]
        public MembersInfo AddMembersInfo { get; set; }

        [BindProperty]
        public string userId { get; set; }

        public SubmitApplicationModel(IMemberApplicationRepository memberApplicationRepository, UserManager<ApplicationUser> userManager)
        {
            this.memberApplicationRepository = memberApplicationRepository;
            this._userManager = userManager;
        }

        public IActionResult OnGet()
        {
            userId = _userManager.GetUserId(HttpContext.User);
            return Page();
        }
        public async Task<IActionResult> OnPost ()
        {

            var addApplication = new MemberApplication()
            {
                MembershipType = AddApplicationRequest.MembershipType,
                MemberFirstName = AddApplicationRequest.MemberFirstName,
                MemberLastName = AddApplicationRequest.MemberLastName,
                MemberAddress = AddApplicationRequest.MemberAddress,
                MemberCity = AddApplicationRequest.MemberCity,
                MemberProvince = AddApplicationRequest.MemberProvince,
                MemberPostalCode = AddApplicationRequest.MemberPostalCode,
                MemberDOB = AddApplicationRequest.MemberDOB,
                MemberPhoneNumber = AddApplicationRequest.MemberPhoneNumber,
                MemberEmail = AddApplicationRequest.MemberEmail,
                CompanyName = AddApplicationRequest.CompanyName,
                Occupation = AddApplicationRequest.Occupation,
                CompanyAddress = AddApplicationRequest.CompanyAddress,
                CompanyCity = AddApplicationRequest.CompanyCity,
                CompanyProvince = AddApplicationRequest.CompanyProvince,
                CompanyPostalCode = AddApplicationRequest.CompanyPostalCode,
                CompanyPhoneNumber = AddApplicationRequest.CompanyPhoneNumber,
                MemberSignature = AddApplicationRequest.MemberSignature,
                MemberSignDate = AddApplicationRequest.MemberSignDate,
                FirstShareholderFullName = AddApplicationRequest.FirstShareholderFullName,
                SecondShareholderFullName = AddApplicationRequest.SecondShareholderFullName,
                FirstShareholderSignDate = AddApplicationRequest.FirstShareholderSignDate,
                SecondShareholderSignDate = AddApplicationRequest.SecondShareholderSignDate,
                ApplicationStatus = AddApplicationRequest.ApplicationStatus,
                Id = AddApplicationRequest.Id
            };

            var returnApplication = new MemberApplication();

            returnApplication = await memberApplicationRepository.AddAsync(addApplication);

            var addMember = new MembersInfo()
            {
                MemberApplicationApplicationId = returnApplication.ApplicationId,
                MemberFirstName = returnApplication.MemberFirstName,
                MemberLastName = returnApplication.MemberLastName
            };

            await memberApplicationRepository.AddAsync(addMember);

            TempData["MessageDescription"] = "Application has been submitted!";

            return RedirectToPage("/Member/ReviewApplication");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Models.ViewModels;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.ManageApplication
{
    public class SubmitApplicationModel : PageModel
    {
       
        private readonly IMemberApplicationRepository memberApplicationRepository;

        [BindProperty]
        public AddApplication AddApplicationRequest { get; set; }

        public SubmitApplicationModel(IMemberApplicationRepository memberApplicationRepository)
        {
            this.memberApplicationRepository = memberApplicationRepository;
        }

        public void OnGet()
        {
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
            };

           await memberApplicationRepository.AddAsync(addApplication);

            return RedirectToPage("/ManagerApplication/ReviewApplication");
        }
    }
}

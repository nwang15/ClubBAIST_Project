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

        [BindProperty]
        public MembersInfo AddMembersInfo { get; set; }

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

            var returnApplication = new MemberApplication();


          

            //var memberApplicationId = mem
            /* MembersInfo membersInfo = new MembersInfo();

             membersInfo.MemberApplicationApplicationId = addApplication.ApplicationId;
             membersInfo.MemberFirstName = addApplication.MemberFirstName;
             membersInfo.MemberLastName = addApplication.MemberLastName;*/



            returnApplication = await memberApplicationRepository.AddAsync(addApplication);
          //  var applcationId = returnApplication.ApplicationId;

            var addMember = new MembersInfo()
            {
                MemberApplicationApplicationId = returnApplication.ApplicationId,
                MemberFirstName = returnApplication.MemberFirstName,
                MemberLastName = returnApplication.MemberLastName
                //IsMember = AddMembersInfo.IsMember
            };

            await memberApplicationRepository.AddAsync(addMember);

            TempData["MessageDescription"] = "Application has been submitted!";

            return RedirectToPage("/ManageApplication/ReviewApplication");
        }
    }
}

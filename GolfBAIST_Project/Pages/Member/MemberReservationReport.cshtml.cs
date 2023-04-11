using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GolfBAIST_Project.Pages.Member
{
    public class MemberReservationReportModel : PageModel
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty]
        public string message { get; set; }
        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }
        public string userId { get; set; }
        public int ApplicationId { get; set; }

        public int reservationId { get; set; }
        [BindProperty]
        public int memberId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public MembersInfo MembersInfo { get; set; }
        public MemberApplication MemberApplication { get; set; }

        [BindProperty]
        public List<Reservation> reservations { get; set; }

        public MemberReservationReportModel(ApplicationDbContext applicationDbContext,
                                            UserManager<ApplicationUser> userManager)
        {
            this.applicationDbContext = applicationDbContext;
            this.userManager = userManager;
        }
        public void OnGet()
        {
            userId = userManager.GetUserId(HttpContext.User);
            MemberApplication = applicationDbContext.MemberApplications.Where(x => x.Id.Equals(userId)).FirstOrDefault();

            if (MemberApplication.ApplicationStatus != "Accepted")
            {
                message = "You have to be a member first";
            }
            else
            {
                ApplicationId = MemberApplication.ApplicationId;
                MembersInfo = applicationDbContext.MembersInfos.Where(a => a.MemberApplicationApplicationId.Equals(ApplicationId)).FirstOrDefault();
                memberId = MembersInfo.MemberId;         
            }
        }

        public IActionResult OnPost()
        {
            reservations = applicationDbContext.Reservations
                          .Where(a => a.reservationDate >= StartDate && a.reservationDate <= EndDate && a.MembersInfoMemberId.Equals(memberId))
                          .ToList();


            MembersInfo = applicationDbContext.MembersInfos.Where(a => a.MemberId.Equals(memberId)).FirstOrDefault();
            firstName = MembersInfo.MemberFirstName;
            lastName = MembersInfo.MemberLastName;

            return Page();
        }

    }
}

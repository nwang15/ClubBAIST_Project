using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GolfBAIST_Project.Pages.Member
{
    public class ReviewReservationModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public string message { get; set; }
        [BindProperty]
        public MemberApplication MemberApplication { get; set; }

        [BindProperty]
        public List<Reservation> reservations { get; set; }

        [BindProperty]
        public MembersInfo MembersInfo { get; set; }

        public string userId { get; set; }
        public int ApplicationId { get; set; }
        public int memberId { get; set; }

        public ReviewReservationModel(ApplicationDbContext applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            this._applicationDbContext = applicationDbContext;
            this._userManager = userManager;
        }
        public void OnGet()
        {
            userId = _userManager.GetUserId(HttpContext.User);
            MemberApplication = _applicationDbContext.MemberApplications.Where(x => x.Id.Equals(userId)).FirstOrDefault();
           
            if (MemberApplication==null)
            {
                message = "You have be a member first";
            }
            else
            {
                ApplicationId = MemberApplication.ApplicationId;
                MembersInfo = _applicationDbContext.MembersInfos.Where(a => a.MemberApplicationApplicationId.Equals(ApplicationId)).FirstOrDefault();
                memberId = MembersInfo.MemberId;

                reservations = _applicationDbContext.Reservations.Where(c => c.MembersInfoMemberId.Equals(memberId)).ToList();
            }
            
        }
    }
}

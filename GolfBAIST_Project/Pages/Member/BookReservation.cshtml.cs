using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class BookReservationModel : PageModel
    {
        private readonly IMemberReservationRepository memberReservationRepository;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public string message { get; set; }
        public string userId { get; set; }
        public string memberStatus { get; set; }
        public string memberType { get; set; }
        public int ApplicationId { get; set; }
        [BindProperty]
        public int memberId { get; set; }

        [BindProperty]
        public MemberApplication MemberApplication { get; set; }

        [BindProperty]
        public MembersInfo MembersInfo  { get; set; }

        [BindProperty]
        public AddReservation AddReservationRequest { get; set; }


        public BookReservationModel(IMemberReservationRepository memberReservationRepository,
                                    ApplicationDbContext applicationDbContext, 
                                    UserManager<ApplicationUser> userManager)
        {
            this.memberReservationRepository = memberReservationRepository;
            this._applicationDbContext = applicationDbContext;
            this._userManager = userManager;
        }

        public void OnGet()
        {
            userId = _userManager.GetUserId(HttpContext.User);
            MemberApplication = _applicationDbContext.MemberApplications.Where(x => x.Id.Equals(userId)).FirstOrDefault();
            memberStatus = MemberApplication.ApplicationStatus;
            memberType = MemberApplication.MembershipType;
            ApplicationId = MemberApplication.ApplicationId;

            MembersInfo = _applicationDbContext.MembersInfos.Where(a => a.MemberApplicationApplicationId.Equals(ApplicationId)).FirstOrDefault();
            memberId = MembersInfo.MemberId;

        }

        public async Task<IActionResult> OnPost()
        {

            var addReservation = new Reservation()
            {
                reservationDate = AddReservationRequest.reservationDate,
                Players = AddReservationRequest.Players,
                TimeRange = AddReservationRequest.TimeRange,
                MembersInfoMemberId = AddReservationRequest.MembersInfoMemberId
                };

                await memberReservationRepository.AddAsync(addReservation);
          


            return RedirectToPage("/Index");
        }
    }
}

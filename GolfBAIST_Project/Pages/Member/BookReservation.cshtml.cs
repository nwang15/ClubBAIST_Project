using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Models.ViewModels;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.Member
{
    public class BookReservationModel : PageModel
    {
        private readonly IMemberReservationRepository memberReservationRepository;
        private readonly IMemberApplicationRepository memberApplicationRepository;

        [BindProperty]
        public AddReservation AddReservationRequest { get; set; }

        public MemberApplication MemberApplication { get; set; }

        [BindProperty]
        public MembersInfo MembersInfo { get; set; }

        public string memberstatus { get; set; }
        public string Message { get; set; }


        public BookReservationModel(IMemberReservationRepository memberReservationRepository, IMemberApplicationRepository memberApplicationRepository)
        {
            this.memberReservationRepository = memberReservationRepository;
            this.memberApplicationRepository = memberApplicationRepository;
        }

        public async Task OnGet(int applicationId)
        {
            MemberApplication = await memberApplicationRepository.GetAsync(applicationId);
            memberstatus = MemberApplication.ApplicationStatus;

        }

        public async Task<IActionResult> OnPost()
        {
            if (MemberApplication.ApplicationStatus == "Approved")
            {
                var addReservation = new Reservation()
                {
                    reservationDate = AddReservationRequest.reservationDate,
                    StartTime = AddReservationRequest.StartTime,
                    EndTime = AddReservationRequest.EndTime
                };


                await memberReservationRepository.AddAsync(addReservation);
            }
            else
            {

            }




            return RedirectToPage("/Admin/ReviewAllReservations");
        }
    }
}

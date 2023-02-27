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

        [BindProperty]
        public AddReservation AddReservationRequest { get; set; }

        [BindProperty]
        public MembersInfo MembersInfo { get; set; }

        public BookReservationModel(IMemberReservationRepository memberReservationRepository)
        {
            this.memberReservationRepository = memberReservationRepository;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {


            var addReservation = new Reservation()
            {
               reservationDate = AddReservationRequest.reservationDate,
               StartTime = AddReservationRequest.StartTime,
               EndTime = AddReservationRequest.EndTime
            };


            await memberReservationRepository.AddAsync(addReservation);

            TempData["MessageDescription"] = "Reservation has been submitted!";

            return RedirectToPage("/Admin/ReviewAllReservations");
        }
    }
}

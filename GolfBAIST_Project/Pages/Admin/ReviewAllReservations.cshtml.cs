using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.Admin
{
    public class ReviewAllReservationsModel : PageModel
    {
        private readonly IMemberReservationRepository memberReservationRepository;

        public List<Reservation> Reservations { get; set; }

        public ReviewAllReservationsModel(IMemberReservationRepository memberReservationRepository)
        {
            this.memberReservationRepository = memberReservationRepository;
        }
        public async Task OnGet()
        {
            //Reservations = (await memberReservationRepository.GetAllAsync())?.ToList();
        }
    }
}

using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.Member
{
    public class ReservationInfoModel : PageModel
    {
        private readonly IMemberReservationRepository memberReservationRepository;

        [BindProperty]
        public Reservation Reservation { get; set; }

        public ReservationInfoModel(IMemberReservationRepository memberReservationRepository)
        {
            this.memberReservationRepository = memberReservationRepository;
        }
        public async Task OnGet(int reservationId)
        {
            Reservation = await memberReservationRepository.GetAsync(reservationId);
        }
    }
}

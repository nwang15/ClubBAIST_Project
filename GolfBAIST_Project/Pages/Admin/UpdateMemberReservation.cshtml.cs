using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.Admin
{
    public class UpdateMemberReservationModel : PageModel
    {
        private readonly IMemberReservationRepository memberReservationRepository;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public Reservation reservation { get; set; }

        [BindProperty]
        public MemberApplication MemberApplication { get; set; }
        [BindProperty]
        public MembersInfo MembersInfo { get; set; }


        public string userId { get; set; }
        public int ApplicationId { get; set; }
        public int memberId { get; set; }

        public string memberFirstNamme { get; set; }
        public string memberLastName { get; set; }
        [BindProperty]
        public string memberType { get; set; }
        public UpdateMemberReservationModel(IMemberReservationRepository memberReservationRepository, 
                                            ApplicationDbContext applicationDbContext, 
                                            UserManager<ApplicationUser> userManager)
        {
            this.memberReservationRepository = memberReservationRepository;
            this._applicationDbContext = applicationDbContext;
            this._userManager = userManager;
        }
        public async Task OnGet(int reservationId)
        {
           /* userId = _userManager.GetUserId(HttpContext.User);
            MemberApplication = _applicationDbContext.MemberApplications.Where(x => x.Id.Equals(userId)).FirstOrDefault();
            memberFirstNamme = MemberApplication.MemberFirstName;
            memberLastName = MemberApplication.MemberLastName;
            memberType = MemberApplication.MembershipType;
            ApplicationId = MemberApplication.ApplicationId;
            
            MembersInfo = _applicationDbContext.MembersInfos.Where(a => a.MemberApplicationApplicationId.Equals(ApplicationId)).FirstOrDefault();
            memberId = MembersInfo.MemberId;*/

            reservation = await memberReservationRepository.GetAsync(reservationId);
            MembersInfo = _applicationDbContext.MembersInfos.Where(a => a.MemberId.Equals(reservation.MembersInfoMemberId)).FirstOrDefault();
            memberFirstNamme = MembersInfo.MemberFirstName;
            memberLastName = MembersInfo.MemberLastName;
            //ApplicationId = ;

            MemberApplication = _applicationDbContext.MemberApplications.Where(x => x.ApplicationId.Equals(MembersInfo.MemberApplicationApplicationId)).FirstOrDefault();
            memberType = MemberApplication.MembershipType;


        }

        public async Task<IActionResult> OnPostEdit()
        {
            await memberReservationRepository.UpdateAsync(reservation);
            // ViewData["MessageDescription"] = "Record was successfully saved!";

            return Page();
        }
        public async Task<IActionResult> OnPostDelete()
        {
            var deleted = await memberReservationRepository.DeleteAsync(reservation.ReservationId);

            if (deleted)
            {
                return RedirectToPage("/Admin/ReviewAllReservations");
            }
            return Page();
        }
    }
}

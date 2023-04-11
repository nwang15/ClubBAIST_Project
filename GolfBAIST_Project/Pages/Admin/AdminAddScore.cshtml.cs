using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Models.ViewModels;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.Admin
{
    public class AdminAddScoreModel : PageModel
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IMemberScoreRepository _memberScoreRepository;

        [BindProperty]
        public string message { get; set; }
        public string memberStatus { get; set; }
        public int ApplicationId { get; set; }

        [BindProperty]
        public int memberID { get; set; }

        [BindProperty]
        public string memberFirstName { get; set; }

        [BindProperty]
        public string memberLastName { get; set; }


        [BindProperty]
        public MemberApplication MemberApplication { get; set; }

        [BindProperty]
        public MembersInfo MembersInfo { get; set; }

        [BindProperty]
        public AddScoreRequest AddScoreRequest { get; set; }

        public AdminAddScoreModel(ApplicationDbContext applicationDbContext,
                                    IMemberScoreRepository memberScoreRepository)
        {
            _applicationDbContext = applicationDbContext;
            _memberScoreRepository = memberScoreRepository;
        }

        public async Task OnGet(int memberId)
        {

            MembersInfo =  await _memberScoreRepository.GetAsync(memberId);
            ApplicationId = MembersInfo.MemberApplicationApplicationId;
            memberID = MembersInfo.MemberId;
            memberFirstName = MembersInfo.MemberFirstName;
            memberLastName = MembersInfo.MemberLastName;

            MemberApplication = _applicationDbContext.MemberApplications.Where(x => x.ApplicationId.Equals(ApplicationId)).FirstOrDefault();
            memberStatus = MemberApplication.ApplicationStatus;            
        }

        public async Task<IActionResult> OnPost()
        {
            var addScores = new Scores()
            {
                MembersInfoMemberId = AddScoreRequest.MembersInfoMemberId,
                MemberFirstName = AddScoreRequest.MemberFirstName,
                MemberLastName = AddScoreRequest.MemberLastName,
                PlayDate = AddScoreRequest.PlayDate,
                PlayScore = AddScoreRequest.PlayScore,
                Handicap = AddScoreRequest.Handicap,
                UpdatedBy = AddScoreRequest.UpdatedBy
            };

            await _memberScoreRepository.AddAsync(addScores);
            return RedirectToPage("/Admin/GetAllMember");
        }
    }
}

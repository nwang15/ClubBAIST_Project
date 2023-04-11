using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Models.ViewModels;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.Member
{
    public class MemberAddScoreModel : PageModel
    {

        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMemberScoreRepository _memberScoreRepository;

        [BindProperty]
        public string message { get; set; }
        public string userId { get; set; }
        public string memberStatus { get; set; }
        public int ApplicationId { get; set; }

        [BindProperty]
        public int memberId { get; set; }

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

        public MemberAddScoreModel(ApplicationDbContext applicationDbContext,
                                    UserManager<ApplicationUser> userManager,
                                    IMemberScoreRepository memberScoreRepository)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;
            _memberScoreRepository = memberScoreRepository;
        }

        public void OnGet()
        {
            userId = _userManager.GetUserId(HttpContext.User);
            MemberApplication = _applicationDbContext.MemberApplications.Where(x => x.Id.Equals(userId)).FirstOrDefault();
            memberStatus = MemberApplication.ApplicationStatus;
            ApplicationId = MemberApplication.ApplicationId;

            if (MemberApplication == null)
            {
                message = "You need to submit your membership application first";
            }
            else if (memberStatus == "Accepted")
            {
                MembersInfo = _applicationDbContext.MembersInfos.Where(a => a.MemberApplicationApplicationId.Equals(ApplicationId)).FirstOrDefault();
                memberId = MembersInfo.MemberId;
                memberFirstName = MembersInfo.MemberFirstName;
                memberLastName = MembersInfo.MemberLastName;

            }
            else
            {
                message = "You are not a member yet.";
            }

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
            return Page();
        }
        
    }
}

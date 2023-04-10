using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.Member
{
    public class MemberViewScoreModel : PageModel
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

        [BindProperty]
        public int memberId { get; set; }

        public MemberApplication MemberApplication { get; set; }
        public MembersInfo MembersInfo { get; set; }
        public Scores score { get; set; }

        [BindProperty]
        public List<Scores> AllScores { get; set; }

        [BindProperty]
        public List<Scores> ScoresWDate { get; set; }

        public MemberViewScoreModel(ApplicationDbContext applicationDbContext,
                                    UserManager<ApplicationUser> userManager)
        {
            this.applicationDbContext = applicationDbContext;
            this.userManager = userManager;
        }
        public void OnGet()
        {
            userId = userManager.GetUserId(HttpContext.User);
            MemberApplication = applicationDbContext.MemberApplications.Where(x => x.Id.Equals(userId)).FirstOrDefault();


            if (MemberApplication == null)
            {
                message = "You need to submit your membership application first";
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
            ScoresWDate = applicationDbContext.Scores
                          .Where(a => a.PlayDate >= StartDate && a.PlayDate <= EndDate && a.MembersInfoMemberId.Equals(memberId))
                          .ToList();

            return Page();
        }

    }
}

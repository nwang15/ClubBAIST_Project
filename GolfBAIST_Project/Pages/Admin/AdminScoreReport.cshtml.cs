using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System;
using GolfBAIST_Project.Repositories;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.Admin
{
    public class AdminScoreReportModel : PageModel
    {
        private readonly IMemberScoreRepository memberScoreRepository;
        private readonly ApplicationDbContext applicationDbContext;

        [BindProperty]
        public string message { get; set; }

        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }

        [BindProperty]
        public int memberId { get; set; }

        public MemberApplication MemberApplication { get; set; }
        public MembersInfo MembersInfo { get; set; }
        public Scores score { get; set; }

        [BindProperty]
        public List<Scores> AllScores { get; set; }


        public AdminScoreReportModel(IMemberScoreRepository memberScoreRepository,
                                     ApplicationDbContext applicationDbContext)
        {
            this.memberScoreRepository = memberScoreRepository;
            this.applicationDbContext = applicationDbContext;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPostDate()
        {
            AllScores = applicationDbContext.Scores
                          .Where(a => a.PlayDate >= StartDate && a.PlayDate <= EndDate)
                          .ToList();

            return Page();
        }
        public IActionResult OnPostMember()
        {
            AllScores =  applicationDbContext.Scores.Where(x => x.MembersInfoMemberId.Equals(memberId)).ToList();
            // ViewData["MessageDescription"] = "Record was successfully saved!";

            return Page();
        }

    }
}

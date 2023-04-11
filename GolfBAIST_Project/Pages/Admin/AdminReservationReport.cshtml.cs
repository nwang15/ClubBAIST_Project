using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GolfBAIST_Project.Pages.Admin
{
    public class AdminReservationReportModel : PageModel
    {
        private readonly ApplicationDbContext applicationDbContext;

        [BindProperty]
        public DateTime StartDate { get; set; }

        [BindProperty]
        public DateTime EndDate { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        [BindProperty]
        public int memberId { get; set; }

        public List<MembersInfo> MembersInfo { get; set; }
        public List<Reservation> Reservations { get; set; }
        public AdminReservationReportModel(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPostDate()
        {
            Reservations = applicationDbContext.Reservations
                          .Where(a => a.reservationDate >= StartDate && a.reservationDate <= EndDate)
                          .ToList();
            foreach (var res in Reservations)
            {
                MembersInfo = applicationDbContext.MembersInfos.Where(a => a.MemberId.Equals(res.MembersInfoMemberId)).ToList();
            }
            return Page();
        }
        public IActionResult OnPostMember()
        {
            Reservations = applicationDbContext.Reservations.Where(x => x.MembersInfoMemberId.Equals(memberId)).ToList();
            foreach (var res in Reservations)
            {
                MembersInfo = applicationDbContext.MembersInfos.Where(a => a.MemberId.Equals(res.MembersInfoMemberId)).ToList();
            }
            return Page();
            // ViewData["MessageDescription"] = "Record was successfully saved!";

            return Page();
        }
    }
}

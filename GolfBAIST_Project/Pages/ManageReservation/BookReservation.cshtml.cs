using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.ManageReservation
{
    public class BookReservationModel : PageModel
    {
        [BindProperty]
        public Reservation Reservation { get; set; }

        public BookReservationModel()
        {

        }

        public void OnGet()
        {
        }
    }
}

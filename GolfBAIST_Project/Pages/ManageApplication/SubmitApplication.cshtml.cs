using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages.ManageApplication
{
    public class SubmitApplicationModel : PageModel
    {
        [BindProperty]
        public AddApplication AddApplicationRequest { get; set; }

        public void OnGet()
        {
        }
        public void OnPost ()
        {

        }
    }
}

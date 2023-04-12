using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfBAIST_Project.Pages
{
    public class FindDatabaseUserModel : PageModel
    {
        public DatabaseUser CurrentDatabaseUser { get; set; }

        public void OnGet()
        {
            BCS RequestDirector = new();
            CurrentDatabaseUser = RequestDirector.FindDatabaseUser();
        }
    }
}

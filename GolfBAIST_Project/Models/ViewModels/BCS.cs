using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.TechnicalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Models.ViewModels
{
    public class BCS
    {
        public DatabaseUser FindDatabaseUser()
        {
            DatabaseUsers DatabaseUserManager = new();
            DatabaseUser CurrentDatabaseUser = DatabaseUserManager.GetDatabaseUser();

            return CurrentDatabaseUser;
        }
    }
}

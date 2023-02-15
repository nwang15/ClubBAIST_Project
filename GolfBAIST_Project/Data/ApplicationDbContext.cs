using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GolfBAIST_Project.Data
{   
    public class ApplicationUser:IdentityUser
    {
        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string LastName { get; set; }
            
    }
    public class ApplicationDbContext : IdentityDbContext <ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }

        public DbSet<MemberApplication> MemberApplications { get; set; }
        public DbSet<MembersInfo> MembersInfos { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
}

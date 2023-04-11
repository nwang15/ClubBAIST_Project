using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Models.ViewModels
{
    public class AddReservation
    {
        public int MembersInfoMemberId { get; set; }
        public DateTime reservationDate { get; set; }
        public string TimeRange { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Players { get; set; }
    }
}

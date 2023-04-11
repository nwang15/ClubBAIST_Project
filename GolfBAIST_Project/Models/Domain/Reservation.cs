using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace GolfBAIST_Project.Models.Domain
{
    public class Reservation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }
        public int MembersInfoMemberId { get; set; }
        public DateTime reservationDate { get; set; }
        public string TimeRange { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Players { get; set; }
    }
}

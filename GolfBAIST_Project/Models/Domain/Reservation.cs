using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfBAIST_Project.Models.Domain
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservationId { get; set; }
        public Guid MemberId { get; set; }
        public DateTime reservationDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int Players { get; set; }

        public string Holes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Models.Domain
{
    public class MembersInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MemberId { get; set; }
        public int MemberApplicationApplicationId { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }

        public ICollection<Reservation> reservations { get; set; }
        public ICollection<Scores> scores { get; set; }
    }
}

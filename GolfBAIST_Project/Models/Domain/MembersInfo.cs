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

        [ForeignKey("MemberApplication")]
        public int ApplicationId { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }

        public ICollection<Reservation> reservations { get; set; }
    }
}

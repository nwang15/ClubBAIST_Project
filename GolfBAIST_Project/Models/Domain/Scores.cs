using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace GolfBAIST_Project.Models.Domain
{
    public class Scores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScoreID { get; set; }
        public int MembersInfoMemberId { get; set; } 
        public string MemberFirstName { get; set; }
        public string MemberLastName   { get; set; }
        public DateTime PlayDate { get; set; }
        public int PlayScore { get; set; }
        public int Handicap { get; set; }
        public string UpdatedBy { get; set; }

                    
    }
}

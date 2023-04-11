using System;

namespace GolfBAIST_Project.Models.ViewModels
{
    public class AddScoreRequest
    {
        public int MembersInfoMemberId { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public DateTime PlayDate { get; set; }
        public int PlayScore { get; set; }
        public int Handicap { get; set; }
        public string UpdatedBy { get; set; }
    }
}

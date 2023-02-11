using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfBAIST_Project.Entities
{
    public class MemberApplication
    {
        public int ApplicationID { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public string MemberSignature { get; set; }
        public DateTime MemberSignDate { get; set; }
        public string FirstShareholderFullName { get; set; }
        public string FirstShareholderSignature { get; set; }
        public DateTime FirstShareholderSignDate { get; set; }
        public string SecondShareholderFullName { get; set; }
        public string SecondShareholderSignature { get; set; }
        public DateTime SecondShareholderSignDate { get; set; }
        public string ApplicationStatus { get; set; }

        [ForeignKey("ApplicationID")]
        public ICollection<MembersInfo> membersInfos { get; set; }



    }
}

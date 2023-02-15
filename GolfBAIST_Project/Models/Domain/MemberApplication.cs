using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Models.Domain
{
    public class MemberApplication
    {
        public Guid ApplicationId { get; set; }
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


    }
}

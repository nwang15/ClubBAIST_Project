using GolfBAIST_Project.Data;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }
        public string Id { get; set; }
        public string MembershipType { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public string MemberAddress { get; set; }
        public string MemberCity { get; set; }
        public string MemberProvince { get; set; }
        public string MemberPostalCode { get; set; }
        public string MemberPhoneNumber { get; set; }
        public string MemberEmail { get; set; }
        public DateTime MemberDOB { get; set; }
        public string Occupation { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyProvince { get; set; }
        public string CompanyPostalCode { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string MemberSignature { get; set; }
        public DateTime MemberSignDate { get; set; }
        public string FirstShareholderFullName { get; set; }
        public string FirstShareholderSignature { get; set; }
        public DateTime FirstShareholderSignDate { get; set; }
        public string SecondShareholderFullName { get; set; }
        public string SecondShareholderSignature { get; set; }
        public DateTime SecondShareholderSignDate { get; set; }
        public string ApplicationStatus { get; set; }

        //Navigation Property       
        public virtual MembersInfo MembersInfos { get; set; }

        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }

    }
}

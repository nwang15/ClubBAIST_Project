using System;
using System.ComponentModel.DataAnnotations;

namespace GolfBAIST_Project.Entities
{
    public class MembersInfo
    {
        public int MemberId { get; set; }
        public int ApplicationID { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Occupation { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyProvince { get; set; }
        public string CompanyPostalCode { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public bool IsMember { get; set; }
    }
}

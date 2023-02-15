using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Models.ViewModels
{
    public class AddApplication
    {
        public string MembershipType { get; set; }
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

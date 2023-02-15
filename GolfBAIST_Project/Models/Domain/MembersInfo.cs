using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Models.Domain
{
    public class MembersInfo
    {

        public Guid MemberId { get; set; }
        public int ApplicationID { get; set; }
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        public bool IsMember { get; set; }
    }
}

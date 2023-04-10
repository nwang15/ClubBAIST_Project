using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using GolfBAIST_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Pages.Admin
{
    public class GetAllMemberModel : PageModel
    {
        private readonly IMemberApplicationRepository memberApplicationRepository;
        private readonly IMemberScoreRepository memberScoreRepository;
        private readonly ApplicationDbContext applicationDbContext;

        public List<MemberApplication> MemberApplications { get; set; }
        public List<MembersInfo>  membersInfos { get; set; }

        public int applicationId { get; set; }

        public GetAllMemberModel(IMemberApplicationRepository memberApplicationRepository, 
                                IMemberScoreRepository memberScoreRepository,
                                ApplicationDbContext applicationDbContext)
        {
            this.memberApplicationRepository = memberApplicationRepository;
            this.memberScoreRepository = memberScoreRepository;
            this.applicationDbContext = applicationDbContext;
        }
        public async Task OnGet()
        {
            MemberApplications = (await memberApplicationRepository.GetAllAsync())?.ToList();
            membersInfos = (await memberScoreRepository.GetAllAsync())?.ToList();
        }
    }
}

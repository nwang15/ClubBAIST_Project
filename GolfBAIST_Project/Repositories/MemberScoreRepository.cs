using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Repositories
{
    public class MemberScoreRepository : IMemberScoreRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

      

        public MemberScoreRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Scores> AddAsync(Scores scores)
        {
            await applicationDbContext.Scores.AddAsync(scores);
            await applicationDbContext.SaveChangesAsync();
            return scores;
        }

        public async Task<IEnumerable<MembersInfo>> GetAllAsync()
        {
            return await applicationDbContext.MembersInfos.ToListAsync();
        }

        public async Task<IEnumerable<Scores>> GetAllScoreAsync()
        {
            return await applicationDbContext.Scores.ToListAsync();
        }

        public async Task<MembersInfo> GetAsync(int memberId)
        {
            return await applicationDbContext.MembersInfos.FindAsync(memberId);
        }
    }
}

using GolfBAIST_Project.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Repositories
{
    public interface IMemberScoreRepository
    {
        //Get all members
        Task<IEnumerable<MembersInfo>> GetAllAsync();
        Task<IEnumerable<Scores>> GetAllScoreAsync();
        Task<MembersInfo> GetAsync(int memberId);
        Task<Scores> AddAsync(Scores scores);
    }
}

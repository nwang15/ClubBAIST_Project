using GolfBAIST_Project.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Repositories
{
   public interface IMemberApplicationRepository
    {
        //Member Application
        Task<IEnumerable<MemberApplication>> GetAllAsync();
        Task<MemberApplication> GetAsync(int applicationId);
        Task<MemberApplication> AddAsync(MemberApplication memberApplication);
        Task<MemberApplication> UpdateAsync(MemberApplication memberApplication);
        Task<bool> DeleteAsync(int applicationId);

        //Reservation
        Task<Reservation> AddAsync(Reservation reservation);
        Task<Reservation> GetAReservation(int reservationId);
        //Member
        Task<MembersInfo> AddAsync(MembersInfo membersInfo);
        
        

    }
}

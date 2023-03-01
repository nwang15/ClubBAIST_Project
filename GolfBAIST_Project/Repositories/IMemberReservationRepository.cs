using GolfBAIST_Project.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Repositories
{
   public interface IMemberReservationRepository
    {
        //Reservation
        Task<Reservation> AddAsync(Reservation reservation);
        Task<Reservation> GetAReservation(int reservationId);
        Task<IEnumerable<Reservation>> GetAllAsync();

        //get member application info to check if application status for Book Reservation
       /* Task<MemberApplication> GetAsync(int applicationId, string userId);*/

    }
}

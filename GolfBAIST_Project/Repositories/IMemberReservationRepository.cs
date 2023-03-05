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
        Task<IEnumerable<Reservation>> GetAllAsync();
        Task<Reservation> AddAsync(Reservation reservation);
        Task<Reservation> GetAsync(int reservationId);
        Task<Reservation> UpdateAsync(Reservation reservation);


    }
}

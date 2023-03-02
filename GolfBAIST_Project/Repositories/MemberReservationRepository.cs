using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Repositories
{
    public class MemberReservationRepository : IMemberReservationRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public MemberReservationRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //Submit A Reservation
        public async Task<Reservation> AddAsync(Reservation reservation)
        {
            await applicationDbContext.Reservations.AddAsync(reservation);
            await applicationDbContext.SaveChangesAsync();
            return reservation;
        }

    

       
    }
}

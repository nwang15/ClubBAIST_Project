using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public async Task<bool> DeleteAsync(int reservationId)
        {
            var existingReservation = await applicationDbContext.Reservations.FindAsync(reservationId);

            if (existingReservation != null)
            {
                applicationDbContext.Reservations.Remove(existingReservation);
                await applicationDbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            return await applicationDbContext.Reservations.ToListAsync();
        }

        public async Task<Reservation> GetAsync(int reservationId)
        {
            return await applicationDbContext.Reservations.FindAsync(reservationId);
        }

        public async Task<Reservation> UpdateAsync(Reservation reservation)
        {
            var existingReservation = await applicationDbContext.Reservations.FindAsync(reservation.ReservationId);

            if (existingReservation !=null)
            {
                existingReservation.reservationDate = reservation.reservationDate;
                existingReservation.TimeRange = reservation.TimeRange;
                existingReservation.Players = reservation.Players;

                await applicationDbContext.SaveChangesAsync();
            }
            return existingReservation;
        }
    }
}

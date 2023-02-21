using GolfBAIST_Project.Data;
using GolfBAIST_Project.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfBAIST_Project.Repositories
{
    public class MemberApplicationRepository : IMemberApplicationRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public MemberApplicationRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<MemberApplication> AddAsync(MemberApplication memberApplication)
        {
            await applicationDbContext.MemberApplications.AddAsync(memberApplication);
            await applicationDbContext.SaveChangesAsync();
            return memberApplication;
        }

        public async Task<bool> DeleteAsync(int applicationId)
        {
            var existingApplication = await applicationDbContext.MemberApplications.FindAsync(applicationId);

            if (existingApplication !=null)
            {
                applicationDbContext.MemberApplications.Remove(existingApplication);
                await applicationDbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<MemberApplication>> GetAllAsync()
        {
          return await applicationDbContext.MemberApplications.ToListAsync();    
        }

        public async Task<MemberApplication> GetAllAsync(int applicationId)
        {
            return await applicationDbContext.MemberApplications.FindAsync(applicationId);
        }

        public async Task<MemberApplication> UpdateAsync(MemberApplication memberApplication)
        {
            var existingApplication = await applicationDbContext.MemberApplications.FindAsync(memberApplication.ApplicationId);

            if (existingApplication != null)
            {
                existingApplication.MembershipType = memberApplication.MembershipType;
                existingApplication.MemberFirstName = memberApplication.MemberFirstName;
                existingApplication.MemberLastName = memberApplication.MemberLastName;
                existingApplication.MemberAddress = memberApplication.MemberAddress;
                existingApplication.MemberCity = memberApplication.MemberCity;
                existingApplication.MemberProvince = memberApplication.MemberProvince;
                existingApplication.MemberPostalCode = memberApplication.MemberPostalCode;
                existingApplication.MemberDOB = memberApplication.MemberDOB;
                existingApplication.MemberPhoneNumber = memberApplication.MemberPhoneNumber;
                existingApplication.MemberEmail = memberApplication.MemberEmail;
                existingApplication.CompanyName = memberApplication.CompanyName;
                existingApplication.Occupation = memberApplication.Occupation;
                existingApplication.CompanyAddress = memberApplication.CompanyAddress;
                existingApplication.CompanyCity = memberApplication.CompanyCity;
                existingApplication.CompanyProvince = memberApplication.CompanyProvince;
                existingApplication.CompanyPostalCode = memberApplication.CompanyPostalCode;
                existingApplication.CompanyPhoneNumber = memberApplication.CompanyPhoneNumber;
                existingApplication.MemberSignature = memberApplication.MemberSignature;
                existingApplication.MemberSignDate = memberApplication.MemberSignDate;
                existingApplication.FirstShareholderFullName = memberApplication.FirstShareholderFullName;
                existingApplication.SecondShareholderFullName = memberApplication.SecondShareholderFullName;
                existingApplication.FirstShareholderSignDate = memberApplication.FirstShareholderSignDate;
                existingApplication.SecondShareholderSignDate = memberApplication.SecondShareholderSignDate;
            }

            await applicationDbContext.SaveChangesAsync();
            return existingApplication;
        }
    }
}

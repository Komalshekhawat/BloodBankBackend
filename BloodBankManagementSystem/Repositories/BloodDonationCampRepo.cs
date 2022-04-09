using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;

using BloodBankManagementSystem.DBContext;

namespace BloodBankManagementSystem.Repositories
{
    public class BloodDonationCampRepo : IBloodDonationCamp
    {
        private MainContext _context = null;
        public BloodDonationCampRepo(MainContext context)
        {
            _context = context;
        }
        public void AddBloodDonationCamp(BloodDonationCamp bloodDonationCamp)
        {
            _context.BloodDonationCamps.Add(bloodDonationCamp);
            _context.SaveChanges();
          
        }

        public List<BloodDonationCamp> GetAllBloodDonationCamps()
        {
            return _context.BloodDonationCamps.ToList();
          
        }

        public BloodDonationCamp GetBloodDonationStartDate(int id)
        {
            return _context.BloodDonationCamps.Find(id);
           
        }
    }
}

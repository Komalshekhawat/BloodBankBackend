using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.DBContext;
using BloodBankManagementSystem.Entities;

namespace BloodBankManagementSystem.Repositories
{
    public class BloodDonorRepository : IBloodDonorRepository
    {
        private MainContext _context = null;

        public object[] BloodDonorID { get; private set; }

        public BloodDonorRepository(MainContext context)
        {
            _context = context;
        }

        public List<BloodDonor> GetBloodDonors()
        {
            return _context.BloodDonors.ToList();
        }

        public void AddBloodDonor(BloodDonor bloodDonor)
        {
            _context.BloodDonors.Add(bloodDonor);
            _context.SaveChanges();
        }

        public void RemoveBloodDonor(int BloodDonorID)
        {
            BloodDonor bloodDonor = _context.BloodDonors.Find(BloodDonorID);
            _context.BloodDonors.Remove(bloodDonor);
            _context.SaveChanges();
        }

       

        public void DonateBlood(BloodDonorDonation bloodDonorDonation)
        {
            _context.BloodDonorDonations.Add(bloodDonorDonation);
            _context.SaveChanges();

        }

        public void UpdateBloodDonor(BloodDonor bloodDonor)
        {
            _context.BloodDonors.Update(bloodDonor);
            _context.SaveChanges();
        }
    }
}

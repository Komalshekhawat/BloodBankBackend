using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;

using BloodBankManagementSystem.DBContext;

namespace BloodBankManagementSystem.Repositories
{
    public class BloodBankRepository : IBloodBankRepository
    {
        //public static List<BloodBank> BloodBanks
        //{
        private MainContext _context = null;
        public BloodBankRepository(MainContext context)
        {
            _context = context;
        }
        public List<BloodBank> GetBloodBanks()
        {
            return _context.BloodBanks.ToList();
        }
        public void AddBloodBank(BloodBank bloodBank)
        {
            _context.BloodBanks.Add(bloodBank);
            _context.SaveChanges();
        }

        public void RemoveBloodBank(string BloodBankName)
        {
            BloodBank bloodBank = _context.BloodBanks.Find(BloodBankName);
            _context.BloodBanks.Remove(bloodBank);
            _context.SaveChanges();
        }

        public void UpdateBloodBank(BloodBank bloodBank)
        {
            _context.BloodBanks.Update(bloodBank);
            _context.SaveChanges();
        }

        public BloodBank GetBloodBank(string BloodBankName)
        {
            return _context.BloodBanks.Find(BloodBankName);
        }
    }
}

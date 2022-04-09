using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using BloodBankManagementSystem.Repositories;
using BloodBankManagementSystem.DBContext;
namespace BloodBankManagementSystem.Repositories
{
    public class BloodInventoryRepository : IBloodInventoryRepository
    {
        private MainContext _context = null;

        public BloodInventoryRepository(MainContext context)
        {
            _context = context;
        }

        public void Delete(int BloodInventoryID)
        {
            BloodInventory bloodInventory = _context.BloodInventories.Find(BloodInventoryID);
            _context.BloodInventories.Remove(bloodInventory);
            _context.SaveChanges();

        }

        public List<BloodInventory> GetAllBloodInventories()
        {
            return _context.BloodInventories.ToList();
        }

        public BloodInventory GetBloodInventories(int BloodInventoryID)
        {
            throw new NotImplementedException();
        }

        public void Update(BloodInventory bloodInventory)
        {
            _context.BloodInventories.Update(bloodInventory);
            _context.SaveChanges();

        }
    }
}

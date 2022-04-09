using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;
namespace BloodBankManagementSystem.Repositories
{
    public interface IBloodInventoryRepository
    {
        List<BloodInventory> GetAllBloodInventories();
        BloodInventory GetBloodInventories(int BloodInventoryID);
        void Update(BloodInventory bloodInventory);
        void Delete(int BloodInventoryID);


    }
}

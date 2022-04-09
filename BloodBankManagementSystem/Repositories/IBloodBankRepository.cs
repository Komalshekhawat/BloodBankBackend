using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;

namespace BloodBankManagementSystem.Repositories
{
   public interface IBloodBankRepository
    {
        List<BloodBank> GetBloodBanks();
        BloodBank GetBloodBank(string BloodBankName);
        void AddBloodBank(BloodBank bloodBank);
        void RemoveBloodBank(string BloodBankName);
        void UpdateBloodBank(BloodBank bloodBank);
    }
}

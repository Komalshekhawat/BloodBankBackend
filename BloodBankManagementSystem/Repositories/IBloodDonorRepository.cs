using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;
using BloodBankManagementSystem.Repositories;

namespace BloodBankManagementSystem.Repositories
{
    public interface IBloodDonorRepository
    {
        List<BloodDonor> GetBloodDonors();

        void AddBloodDonor(BloodDonor bloodDonor);
        void RemoveBloodDonor(int BloodDonorID);
        void UpdateBloodDonor(BloodDonor bloodDonor);

        void DonateBlood(BloodDonorDonation bloodDonorDonation);
        
    }
}

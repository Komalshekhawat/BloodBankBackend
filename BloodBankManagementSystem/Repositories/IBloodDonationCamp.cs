using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;

namespace BloodBankManagementSystem.Repositories
{
    public interface IBloodDonationCamp
    {
        void AddBloodDonationCamp(BloodDonationCamp bloodDonationCamp); //to arrange new camp and add details of camp
        BloodDonationCamp GetBloodDonationStartDate( int id); //to send the start date so that user can get edit option

        List<BloodDonationCamp> GetAllBloodDonationCamps();
    }
}

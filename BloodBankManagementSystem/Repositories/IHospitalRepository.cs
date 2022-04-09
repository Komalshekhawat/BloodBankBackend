using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;

namespace BloodBankManagementSystem.Repositories
{
    public interface IHospitalRepository
    {
        List<Hospital> GetHospitalDetails(int hospitalID);
        void AddHospitalDetails(Hospital hospital);
        void RemoveHospital(int HospitalID);
        void UpdateHospital(Hospital hospital);
        List<Hospital> GetHospitalDetails();
    }
}
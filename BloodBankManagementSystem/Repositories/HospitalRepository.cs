using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;
using BloodBankManagementSystem.DBContext;

namespace BloodBankManagementSystem.Repositories
{ 

    public class HospitalRepository : IHospitalRepository
{

    private MainContext _context = null;
    //Injecting context class to the Hospital Repository Using DI 
    public HospitalRepository(MainContext context)
    {
        _context = context;
    }
    public void AddHospitalDetails(Hospital hospital)//Adding Hospital Details
    {
        //Adding Hospital Details 
        _context.Hospitals.Add(hospital);
        _context.SaveChanges();
    }

    public List<Hospital> GetHospitalDetails()//Getting Hospital Details
    {

        return _context.Hospitals.ToList();
    }

    public List<Hospital> GetHospitalDetails(int hospitalID)
    {
        throw new NotImplementedException();
    }

    public void RemoveHospital(int HospitalID)//Removing Details By Using HospitalID
    {
        Hospital hospital = _context.Hospitals.Find(HospitalID);
        _context.Hospitals.Remove(hospital);
        _context.SaveChanges();
    }

    public void UpdateHospital(Hospital hospital)//updating Details
    {
        _context.Hospitals.Update(hospital);
        _context.SaveChanges();
    }
}
}
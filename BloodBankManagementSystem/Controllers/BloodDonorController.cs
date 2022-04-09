using BloodBankManagementSystem.Entities;
using BloodBankManagementSystem.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodDonorController : ControllerBase
    {
        private IBloodDonorRepository _repository = null;
        public BloodDonorController(IBloodDonorRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("GetBloodDonors")]
        public IActionResult Get()
        {
            List<BloodDonor> bloodDonors = _repository.GetBloodDonors();
            return Ok(bloodDonors);
        }
        [HttpPost]
        [Route("AddBloodDonor")]
        public IActionResult AddBloodDoor(BloodDonor bloodDonor)
        {
            try
            {
                _repository.AddBloodDonor(bloodDonor);
                return Ok("Blood Donor Added"); //empty response
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateBloodDonor")]
        public IActionResult UpdateBloodDonor(BloodDonor bloodDonor)
        {
            try
            {
                _repository.UpdateBloodDonor( bloodDonor);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("RemoveBloodDonor/{id}")]
        public IActionResult RemoveBloodDonor(int BloodDonorID)
        {
            try
            {
                _repository.RemoveBloodDonor(BloodDonorID);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("DonateBlood")]
        public IActionResult AddBloodDonarDonation(BloodDonorDonation bloodDonorDonation)
        {
            try
            {
                _repository.DonateBlood(bloodDonorDonation);
                return Ok("Blood Donar Donation Detail Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;
using BloodBankManagementSystem.Repositories;

namespace BloodBankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private IHospitalRepository _repository = null;
        public HospitalController(IHospitalRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("GetHospitalDetails")]
        public IActionResult Get()//returns the Http Response
        {
            List<Hospital> hospitals = _repository.GetHospitalDetails();
            return Ok(hospitals);
        }
        [HttpPost]
        [Route("AddHospitalDetails")]
        public IActionResult AddHospitalDetails(Hospital hospital)
        {
            try
            {
                _repository.AddHospitalDetails(hospital);
                return Ok("Details Added"); //empty response
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateHospital")]
        public IActionResult UpdateHospital(Hospital hospital)
        {
            try
            {
                _repository.UpdateHospital(hospital);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("RemoveHospitalDetails")]
        public IActionResult RemoveHospital(int HospitalID)
        {
            try
            {
                _repository.RemoveHospital(HospitalID);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
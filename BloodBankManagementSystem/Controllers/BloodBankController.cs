using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Repositories;
using BloodBankManagementSystem.Entities;
using Microsoft.AspNetCore.Mvc;
namespace BloodBankManagementSystem.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class BloodBankController : ControllerBase
    {
        private IBloodBankRepository _repository = null;
        public BloodBankController(IBloodBankRepository repository)
        {
            _repository = repository;

        }
        [HttpGet]
        [Route("GetBloodBanks")]
        public IActionResult Get()
        {
            List<BloodBank> bloodBanks = _repository.GetBloodBanks();
            return Ok(bloodBanks);
        }
        [HttpPost]
        [Route("AddBloodBank")]
        public IActionResult AddBloodBank(BloodBank bloodBank)
        {
            try
            {
                _repository.AddBloodBank(bloodBank);
                return Ok("Blood Bank Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateBloodBank")]
        public IActionResult UpdateBloodBank(BloodBank bloodBank)
        {
            try
            {
                _repository.UpdateBloodBank(bloodBank);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}


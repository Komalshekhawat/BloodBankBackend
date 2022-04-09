using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodBankManagementSystem.Entities;
using BloodBankManagementSystem.Repositories;
using Microsoft.AspNetCore.Cors;

namespace BloodBankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BloodInventoryController : ControllerBase
    {
        private IBloodInventoryRepository _repository = null;

        public BloodInventoryController(IBloodInventoryRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("GetBloodInventories")]
        public IActionResult Get()
        {
            List<BloodInventory> bloodInventory = _repository.GetAllBloodInventories();
            return Ok(bloodInventory); //sending producs as responsone
        }

        [HttpGet]
        [Route("GetBloodInventoriesById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                BloodInventory bloodInventory = _repository.GetBloodInventories(id);
                if (bloodInventory != null)
                    return Ok(bloodInventory);
                else
                    return Content("Invalid");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }


        [HttpPut]
        [Route("UpdateBloodInventory")]
        public IActionResult UpdateBI(BloodInventory bloodInventory)
        {
            try
            {
                _repository.Update(bloodInventory);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteBloodInventory/{id}")]
        public IActionResult DeleteBI(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}

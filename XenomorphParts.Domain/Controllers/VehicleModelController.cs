using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.Services;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Persistence.Repositories;
using XenomorphParts.Exceptions;

namespace XenomorphParts.Domain.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class VehicleModelController : Controller
    {
        private static readonly IVehicleModelRepository _modelRepo = new VehicleModelRepository();
        private static readonly VehicleModelService _modelService = new VehicleModelService(_modelRepo);


        // GET api/vehiclemodel/getbyid/1234567
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(_modelService.GetById(id));
            }
            catch (VehicleModelNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/vehiclemodel/getbymanufacturer/8901234
        [HttpGet("{maker}")]
        public IActionResult GetByManufacturer(long maker)
        {
            try
            {
                return Ok(_modelService.GetByManufacturerId(maker));
            }
            catch (VehicleModelNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/vehiclemodel/getbymanufacturer/8901234
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_modelService.GetByName(name));
            }
            catch (VehicleModelNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/vehiclemodel/getbymanufacturer/8901234
        [HttpGet("{year}")]
        public IActionResult GetByYear(int year)
        {
            try
            {
                return Ok(_modelService.GetByYear(year));
            }
            catch (VehicleModelNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }







        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value) { }


        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value) { }


        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id) { }
    }
}

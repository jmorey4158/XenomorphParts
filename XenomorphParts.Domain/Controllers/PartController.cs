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
    public class PartController : Controller
    {
        private static readonly IPartRepository _partRepo = new PartRepository();
        private static readonly PartService _partService = new PartService(_partRepo);

        // GET api/part/getbyid/1234567
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(_partRepo.GetById(id));
            }
            catch (PartNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/part/getbyname/Hasmodian Particle Injector
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_partRepo.GetByPartName(name));
            }
            catch (PartNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/part/getbymanufacturer/Puldark Interstellar
        [HttpGet("{maker}")]
        public IActionResult GetByManufacturerId(long maker)
        {
            try
            {
                return Ok(_partRepo.GetByManufacturerId(maker));
            }
            catch (PartNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/part/getbymanufacturer/Puldark Interstellar
        [HttpGet("{model}")]
        public IActionResult GetByVehicleModelId(long model)
        {
            try
            {
                return Ok(_partRepo.GetByVehicleModelId(model));
            }
            catch (PartNotFoundException e)
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

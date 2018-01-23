using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.Services;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Persistence.Repositories;
using XenomorphParts.Exceptions;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Domain.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class ManufacturerController : Controller
    {
        private static ControllerHelper _helper = new ControllerHelper();
        private static EntityType type = EntityType.Manufacturer;


        // GET api/manufacturer/getbyid/5
        [HttpGet("{id}")]
        public IActionResult GetById(string id) { return _helper.GetById(id); }


        // GET api/manufacturer/getbyname/Puldark Station
        [HttpGet("{name}")]
        public IActionResult GetByName(string name) { return _helper.GetByName(type, name); }


        // GET api/manufacturer/getbylocation/1234567
        [HttpGet("{location}")]
        public IActionResult GetByLocationId(string location) { return _helper.GetByLocationId(location); }


        // GET api/manufacturer/getbysystem/Yabin
        [HttpGet("{system}")]
        public IActionResult GetBySystem(string system) { return _helper.GetBySystem(type, system); }


        // GET api/manufacturer/getbyplanet/Puldark
        [HttpGet("{planet}")]
        public IActionResult GetByPlanet(string planet) { return _helper.GetByPlanet(type, planet); }


        // GET api/manufacturer/getbyregion/United States of Puldark
        [HttpGet("{region}")]
        public IActionResult GetByRegion(string region) { return _helper.GetByRegion(type, region); }


        // GET api/manufacturer/getbyregion/United States of Puldark
        [HttpGet("{state}")]
        public IActionResult GetByState(string state) { return _helper.GetByState(type, state); }


        // GET api/manufacturer/getbyregion/United States of Puldark
        [HttpGet("{postal}")]
        public IActionResult GetByPostalCode(string postal) { return _helper.GetByPostalCode(type, postal); }







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

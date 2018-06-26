using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Domain.Services;
using XenomorphParts.Persistence.Repositories;
using XenomorphParts.Exceptions;

namespace XenomorphParts.Domain.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class LocationController : Controller
    {
        private static readonly ILocationRepository _locRepo = new LocationRepository();
        private static readonly LocationService _locService = new LocationService(_locRepo);


        // GET api/location/getbyid/234097
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            if ( String.IsNullOrEmpty(id) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_locService.GetById(id));
            }
            catch (LocationNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/location/getbysector/15.38.90.12
        [HttpGet("{galaxy}")]
        public IActionResult GetByGalaxy(string galaxy)
        {
            if ( String.IsNullOrEmpty(galaxy) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_locService.GetByGalaxy(galaxy));
            }
            catch (LocationNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/location/getbysystem/Glabulon
        [HttpGet("{system}")]
        public IActionResult GetBySystem(string system)
        {
            if ( String.IsNullOrEmpty(system) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_locService.GetBySystem(system));
            }
            catch (LocationNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/location/getbyplanet/Puldark Prime
        [HttpGet("{planet}")]
        public IActionResult GetByPlanet(string planet)
        {
            if ( String.IsNullOrEmpty(planet) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_locService.GetByPlanet(planet));
            }
            catch (LocationNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/location/getbyregion/Plextor North
        [HttpGet("{region}")]
        public IActionResult GetByRegion(string region)
        {
            if ( String.IsNullOrEmpty(region) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_locService.GetByRegion(region));
            }
            catch (LocationNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/location/getbystate/Tambari
        [HttpGet("{state}")]
        public IActionResult GetByState(string state)
        {
            if ( String.IsNullOrEmpty(state) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_locService.GetByState(state));
            }
            catch (LocationNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/location/getbypostalcode/12456
        [HttpGet("{postal}")]
        public IActionResult GetByPostalCode(string postal)
        {
            if ( String.IsNullOrEmpty(postal) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_locService.GetByPostalCode(postal));
            }
            catch (LocationNotFoundException e)
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

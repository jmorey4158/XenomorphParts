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
    public class PartLocatorController : Controller
    {
        private static readonly IPartLocatorRepository _partLocRepo = new PartLocatorRepository();
        private static readonly PartLocatorService _partLocService = new PartLocatorService(_partLocRepo);


        // GET api/partlocator/getbylocation/1234567
        [HttpGet("{location}")]
        public IActionResult GetByLocation(long location)
        {
            try
            {
                return Ok(_partLocService.GetByLocation(location));
            }
            catch (PartLocatorNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/partlocator/getbypart/8901234
        [HttpGet("{part}")]
        public IActionResult GetByPart(long part)
        {
            try
            {
                return Ok(_partLocService.GetByPart(part));
            }
            catch (PartLocatorNotFoundException e)
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

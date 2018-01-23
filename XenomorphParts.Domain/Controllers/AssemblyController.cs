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
    public class AssemblyController : Controller
    {
        private static readonly IAssemblyRepository _asmRepo = new AssemblyRepository();
        private static readonly AssemblyService _partService = new AssemblyService(_asmRepo);

        // GET api/assembly/getbyid/1234567
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(_asmRepo.GetById(id));
            }
            catch (AssemblyNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/assembly/getbymanufacturer/Andorian
        [HttpGet("{manufacturer}")]
        public IActionResult GetByManufacturer(string manufacturer)
        {
            try
            {
                return Ok(_asmRepo.GetByManufacturerId(manufacturer));
            }
            catch (AssemblyNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/assembly/getbymodelid/123456
        [HttpGet("{model}")]
        public IActionResult GetByModelId(long model)
        {
            try
            {
                return Ok(_asmRepo.GetByModelId(model));
            }
            catch (AssemblyNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/assembly/getbyname/HyperDrive Injector
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            try
            {
                return Ok(_asmRepo.GetByName(name));
            }
            catch (AssemblyNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/assembly/getbyparent/9801743
        [HttpGet("{parent}")]
        public IActionResult GetByParent(long parent)
        {
            try
            {
                return Ok(_asmRepo.GetByParent(parent));
            }
            catch (AssemblyNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/assembly/getbypartid/9801743
        [HttpGet("{part}")]
        public IActionResult GetByPartId(long part)
        {
            try
            {
                return Ok(_asmRepo.GetByPartId(part));
            }
            catch (AssemblyNotFoundException e)
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

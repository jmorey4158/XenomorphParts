using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Domain.Services;
using XenomorphParts.Persistence.Repositories;
using XenomorphParts.Exceptions;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Domain.Controllers
{
    public class ControllerHelper : Controller
    {
        private static readonly IEntityRepository _entRepo = new EntityRepository();
        private static readonly EntityService _entService = new EntityService(_entRepo);


        public IActionResult GetById(string id)
        {
            try
            {
                return Ok(_entRepo.GetById(id));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }

        public IActionResult GetByName(EntityType type, string name)
        {
            try
            {
                return Ok(_entRepo.GetByName(type, name));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }

        public IActionResult GetByLocationId(string location)
        {
            try
            {
                return Ok(_entRepo.GetByLocationId(location));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }

        public IActionResult GetBySystem(EntityType type, string system)
        {
            try
            {
                return Ok(_entRepo.GetBySystem(type, system));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }

        public IActionResult GetByPlanet(EntityType type, string planet)
        {
            try
            {
                return Ok(_entRepo.GetByPlanet(type, planet));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }

        public IActionResult GetByRegion(EntityType type, string region)
        {
            try
            {
                return Ok(_entRepo.GetByRegion(type, region));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }

        public IActionResult GetByState(EntityType type, string state)
        {
            try
            {
                return Ok(_entRepo.GetByState(type, state));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }

        public IActionResult GetByPostalCode(EntityType type, string postal)
        {
            try
            {
                return Ok(_entRepo.GetByPostalCode(type, postal));
            }
            catch (EntityNotFoundException e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}

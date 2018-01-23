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
    public class ShipmentController : Controller
    {
        private static readonly IShipmentRepository _shipRepo = new ShipmentRepository();
        private static readonly ShipmentService _shipService = new ShipmentService(_shipRepo);


        // GET api/shipment/getbyid/1234567
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(_shipService.GetById(id));
            }
            catch (ShipmentNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/shipment/getbyorder/8901234
        [HttpGet("{order}")]
        public IActionResult GetByOrder(long order)
        {
            try
            {
                return Ok(_shipService.GetByOrderId(order));
            }
            catch (ShipmentNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/shipment/getbcustomerid/8901234
        [HttpGet("{customer}")]
        public IActionResult GetByCustomerId(long customer)
        {
            try
            {
                return Ok(_shipService.GetByCustomerId(customer));
            }
            catch (ShipmentNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }



        // GET api/shipment/getbymethod/UPS
        [HttpGet("{method}")]
        public IActionResult GetByMethod(string method)
        {
            try
            {
                return Ok(_shipService.GetByMethod(method));
            }
            catch (ShipmentNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/shipment/getbystatus/Shipped
        [HttpGet("{status}")]
        public IActionResult GetByStatus(string status)
        {
            try
            {
                return Ok(_shipService.GetByStatus(status));
            }
            catch (ShipmentNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/shipment/getbytype/Fulfilled Backorder
        [HttpGet("{type}")]
        public IActionResult GetByType(string type)
        {
            try
            {
                return Ok(_shipService.GetByType(type));
            }
            catch (ShipmentNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/ordersummary/getbyshippeddate/2356.07.14
        [HttpGet("{date}")]
        public IActionResult GetByShippedDate(string date)
        {
            try
            {
                DateTime _dt = new DateTime();
                if (DateTime.TryParse(date, out _dt))
                {
                    return Ok( _shipRepo.GetByShippedDate(_dt));
                }
                else
                    return BadRequest(new ArgumentException("The date entered is not a valid date. The date must be in the format 'yyy.MM.dd'").Message);
            }
            catch (OrderSummaryNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/ordersummary/getbyreceiveddate/2356.07.14
        [HttpGet("{date}")]
        public IActionResult GetByReceivedDate(string date)
        {
            try
            {
                DateTime _dt = new DateTime();
                if (DateTime.TryParse(date, out _dt))
                {
                    return Ok(_shipRepo.GetByReceivedDate(_dt));
                }
                else
                    return BadRequest(new ArgumentException("The date entered is not a valid date. The date must be in the format 'yyy.MM.dd'").Message);
            }
            catch (OrderSummaryNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }












        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value) { }


        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id) { }
    }
}

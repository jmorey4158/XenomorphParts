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
    public class OrderSummaryController : Controller
    {
        private static readonly IOrderSummaryRepository _orderSummaryRepo = new OrderSummaryRepository();
        private static readonly OrderSummaryService _orderSummaryService = new OrderSummaryService(_orderSummaryRepo);


        // GET api/ordersummary/getbyid/1234567
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(_orderSummaryService.GetById(id));
            }
            catch (OrderSummaryNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/ordersummary/getbyordername/Alexis
        [HttpGet("{name}")]
        public IActionResult GetByOrderName(string name)
        {
            try
            {
                return Ok( _orderSummaryService.GetByOrderName(name) );
            }
            catch (OrderSummaryNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/ordersummary/getbyshipmentid/8901234
        [HttpGet("{shipmentId}")]
        public IActionResult GetByShipmentId(long shipmentId)
        {
            try
            {
                return Ok( _orderSummaryService.GetByShipmentId(shipmentId) );
            }
            catch (OrderSummaryNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/ordersummary/getbyorderdate/2356.07.14
        [HttpGet("{date}")]
        public IActionResult GetByOrderDate(string date)
        {
            try
            {
                DateTime _dt = new DateTime();
                if (DateTime.TryParse(date, out _dt))
                {
                    return Ok(_orderSummaryService.GetByDate(_dt));
                }
                else
                    return BadRequest(new ArgumentException("The date entered is not a valid date. The date must be in the format 'yyy.MM.dd'").Message);

            }
            catch (OrderSummaryNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/ordersummary/getbydaterange/2356.07.13-2358.07.15
        [HttpGet("{range}")]
        public IActionResult GetByDateRange(string range)
        {
            try
            {
                var _range = range.Split('-');
                DateTime _start = new DateTime();
                DateTime _end = new DateTime();
                var _st = DateTime.TryParse(_range[0], out _start);
                var _ed = DateTime.TryParse(_range[1], out _end);

                if (_st && _ed)
                {
                    return Ok(_orderSummaryService.GetByDateRange(_start, _end));
                }
                else
                    return BadRequest(new ArgumentException("The dates entered are not valid dates. The date range must be in the format 'yyy.MM.dd-yyy.MM.dd'").Message);

            }
            catch (OrderSummaryNotFoundException e)
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

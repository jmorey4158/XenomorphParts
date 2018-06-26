using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.Services;
using XenomorphParts.Exceptions;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Persistence.Repositories;

namespace XenomorphParts.Domain.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {

        private static readonly IOrderRepository _orderRepo = new OrderRepository();
        private static readonly OrderService _orderService = new OrderService(_orderRepo);


        // GET api/order/getbyid/1234567
        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            try
            {
                return Ok(_orderService.GetById(id));
            }
            catch (OrderNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/order/getbreferenceyid/1234567
        [HttpGet("{id}")]
        public IActionResult GetByReferenceId(long id)
        {
            try
            {
                return Ok(_orderService.GetByReferenceOrderId(id));
            }
            catch (OrderNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/order/getbycustomerid/1234567
        [HttpGet("{id}")]
        public IActionResult GetByCustomerId(long id)
        {
            try
            {
                return Ok(_orderService.GetByCustomerId(id));
            }
            catch (OrderNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/order/getbyshipmentid/1234567
        [HttpGet("{id}")]
        public IActionResult GetByShipmentId(long id)
        {
            try
            {
                return Ok(_orderService.GetByShipmentId(id));
            }
            catch (OrderNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/order/getbyshipmentid/1234567
        [HttpGet("{date}")]
        public IActionResult GetByDate(string date)
        {
            if ( String.IsNullOrEmpty(date) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                DateTime _dt = new DateTime();
                if (DateTime.TryParse(date, out _dt))
                {
                    return Ok(_orderService.GetByDate(_dt));
                }
                else
                    return BadRequest(new ArgumentException("The date entered is not a valid date. The date must be in the format 'yyy.MM.dd'").Message);
            }
            catch (OrderNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }

        // GET api/order/getbydaterange/2356.07.13-2358.07.15
        [HttpGet("{range}")]
        public IActionResult GetByDateRange(string range)
        {
            if ( String.IsNullOrEmpty(range) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                var _range = range.Split('-');
                DateTime _start = new DateTime();
                DateTime _end = new DateTime();
                var _st = DateTime.TryParse(_range[0], out _start);
                var _ed = DateTime.TryParse(_range[1], out _end);

                if (_st && _ed)
                {
                    return Ok(_orderService.GetByDateRange(_start, _end));
                }
                else
                    return BadRequest(new ArgumentException("The dates entered are not valid dates. The date range must be in the format 'yyy.MM.dd-yyy.MM.dd'").Message);

            }
            catch (OrderNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/order/getbyname/Laxclug
        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            if ( String.IsNullOrEmpty(name) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_orderService.GetByName(name));
            }
            catch (OrderNotFoundException e)
            {
                return BadRequest(e.Message);
            }
        }


        // GET api/order/getbycustomername/Dominion
        [HttpGet("{name}")]
        public IActionResult GetByCustomerName(string name)
        {
            if ( String.IsNullOrEmpty(name) )
            {
                ParameterNullException e = new ParameterNullException("The parameter cannot be null");
                return BadRequest(e.Message);
            }

            try
            {
                return Ok(_orderService.GetByCustomerName(name));
            }
            catch (OrderNotFoundException e)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;

namespace XenomorphParts.Domain.Services
{
    public class OrderSummaryService
    {
        private readonly IOrderSummaryRepository _orderSummaryRepository;

        public OrderSummaryService(IOrderSummaryRepository orderSummaryRepository)
        {
            _orderSummaryRepository = orderSummaryRepository;
        }



        public List<IOrderSummaryDto> GetByOrderName(string name)
        {
            return _orderSummaryRepository.GetByOrderName(name);
        }

        public List<IOrderSummaryDto> GetByDate(DateTime date)
        {
            return _orderSummaryRepository.GetByDate(date);
        }

        public List<IOrderSummaryDto> GetByDateRange(DateTime start, DateTime end)
        {
            return _orderSummaryRepository.GetByDateRange(start, end);
        }


        public IOrderSummaryDto GetById(long id)
        {
            return _orderSummaryRepository.GetById(id);
        }

        public List<IOrderSummaryDto> GetByShipmentId(long shipment)
        {
            return _orderSummaryRepository.GetByShipmentId(shipment);
        }
    }
}

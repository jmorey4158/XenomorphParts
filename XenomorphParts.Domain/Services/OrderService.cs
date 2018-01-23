using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;

namespace XenomorphParts.Domain.Services
{
    public class OrderService : IOrderRepository
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        // METHODS
        public IOrderDto GetById(long id)
        {
           return _orderRepository.GetById(id);
        }

        public List<IOrderDto> GetByCustomerId(long customerId)
        {
            return _orderRepository.GetByCustomerId(customerId);
        }

        public List<IOrderDto> GetByDate(DateTime date)
        {
            return _orderRepository.GetByDate(date);
        }

        public List<IOrderDto> GetByDateRange(DateTime start, DateTime end)
        {
            return _orderRepository.GetByDateRange(start, end);
        }

        public List<IOrderDto> GetByReferenceOrderId(long refId)
        {
            return _orderRepository.GetByReferenceOrderId(refId);
        }

        public List<IOrderDto> GetByShipmentId(long shipmentId)
        {
            return _orderRepository.GetByShipmentId(shipmentId);
        }

        public List<IOrderDto> GetByName(string name)
        {
            return _orderRepository.GetByName(name);
        }

        public List<IOrderDto> GetByCustomerName(string name)
        {
            return _orderRepository.GetByCustomerName(name);
        }
    }
}

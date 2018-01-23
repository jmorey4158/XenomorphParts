using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Domain.Services
{
    public class ShipmentService : IShipmentRepository
    {
        private readonly IShipmentRepository _shipmentRepository;

        public ShipmentService(IShipmentRepository shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }



        public IShipmentDto GetById(long id)
        {
            return _shipmentRepository.GetById(id);
        }

        public IShipmentDto GetByOrderId(long orderId)
        {
            return _shipmentRepository.GetByOrderId(orderId);
        }

        public List<IShipmentDto> GetByMethod(string method)
        {
            return _shipmentRepository.GetByMethod(method);
        }

        public List<IShipmentDto> GetByStatus(string status)
        {
            return _shipmentRepository.GetByStatus(status);
        }

        public List<IShipmentDto> GetByType(string type)
        {
            return _shipmentRepository.GetByType(type);
        }

        public List<IShipmentDto> GetByReceivedDate(DateTime receivedDate)
        {
            return _shipmentRepository.GetByReceivedDate(receivedDate);
        }

        public List<IShipmentDto> GetByShippedDate(DateTime shipDate)
        {
            return _shipmentRepository.GetByShippedDate(shipDate);
        }

        public List<IShipmentDto> GetByCustomerId(long customerId)
        {
            return _shipmentRepository.GetByCustomerId(customerId);
        }




        // NOT YET IMPLMENTED IN CONTROLLER

        public List<IShipmentDto> GetByCustomerIdAndStatus(long customer, string status)
        {
            return _shipmentRepository.GetByCustomerIdAndStatus(customer, status);
        }

        public List<IShipmentDto> GetByCustomerIdAndShippedDate(long customer, DateTime shipDate)
        {
            return _shipmentRepository.GetByCustomerIdAndShippedDate(customer,shipDate);
        }

    }
}

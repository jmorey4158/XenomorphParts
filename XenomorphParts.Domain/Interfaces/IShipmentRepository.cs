using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;
using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IShipmentRepository
    {
        ShipmentDto GetById(long id);
        ShipmentDto GetByOrderId(long orderId);

        List<ShipmentDto> GetByCustomer(string customer);
        List<ShipmentDto> GetByStatus(string status);
        List<ShipmentDto> GetByMethod(string method);
        List<ShipmentDto> GetByType(string status);
        List<ShipmentDto> GetByShippedDate(string shipDate);
        List<ShipmentDto> GetByReceivedDate(string receivedDate);

        List<ShipmentDto> GetByCustomerAndShippedDate(string customer, string shipDate);
        List<ShipmentDto> GetByCustomerAndStatus(string customer, string status);
    }
}

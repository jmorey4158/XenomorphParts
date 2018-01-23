using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IShipmentRepository
    {
        IShipmentDto GetById(long id);
        IShipmentDto GetByOrderId(long orderId);

        List<IShipmentDto> GetByCustomerId(long customerId);

        List<IShipmentDto> GetByStatus(string status);
        List<IShipmentDto> GetByMethod(string method);
        List<IShipmentDto> GetByType(string status);

        List<IShipmentDto> GetByShippedDate(DateTime shipDate);
        List<IShipmentDto> GetByReceivedDate(DateTime receivedDate);
             
        List<IShipmentDto> GetByCustomerIdAndShippedDate(long customer, DateTime shipDate);
        List<IShipmentDto> GetByCustomerIdAndStatus(long customer, string status);
    }
}

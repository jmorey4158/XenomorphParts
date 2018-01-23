using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IOrderRepository
    {
        IOrderDto GetById(long id);
        List<IOrderDto> GetByReferenceOrderId(long customerId);
        List<IOrderDto> GetByName(string name);
        List<IOrderDto> GetByCustomerId(long customerId);
        List<IOrderDto> GetByCustomerName(string name);
        List<IOrderDto> GetByDate(DateTime date);
        List<IOrderDto> GetByDateRange(DateTime start, DateTime end);
        List<IOrderDto> GetByShipmentId(long shipmentId);
    }
}


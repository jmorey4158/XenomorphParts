using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;
using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IShipmentSummaryRepository
    {
        ShipmentSummaryDto GetById(long id);
        ShipmentSummaryDto GetByOrderId(long orderId);

        List<ShipmentSummaryDto> GetByCustomer(ICustomer customer);
        List<ShipmentSummaryDto> GetByStatus(ShipmentStatus status);
        List<ShipmentSummaryDto> GetByMethod(ShipmentMethod method);
        List<ShipmentSummaryDto> GetByType(ShipmentType type);
        List<ShipmentSummaryDto> GetByShippedDate(DateTime shipDate);
        List<ShipmentSummaryDto> GetByReceivedDate(DateTime receivedDate);

        List<ShipmentSummaryDto> GetByCustomerAndShippedDate(ICustomer customer, DateTime shipDate);
        List<ShipmentSummaryDto> GetByCustomerAndStatus(ICustomer customer, ShipmentStatus status);
    }
}

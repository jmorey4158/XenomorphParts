using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IOrderSummaryRepository
    {
        IOrderSummaryDto GetById(long id);
        List<IOrderSummaryDto> GetByOrderName(string name);
        List<IOrderSummaryDto> GetByShipmentId(long shipment);
        List<IOrderSummaryDto> GetByDate(DateTime date);
        List<IOrderSummaryDto> GetByDateRange(DateTime start, DateTime end);
    }
}

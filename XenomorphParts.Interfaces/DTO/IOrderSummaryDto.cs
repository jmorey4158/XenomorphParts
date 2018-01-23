using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IOrderSummaryDto
    {
        long OrderId { get; }
        int ItemsCount { get; }
        string OrderName { get; }
        decimal Total { get; }
        string OrderDate { get; }
        long ShipmentId { get; }
    }
}

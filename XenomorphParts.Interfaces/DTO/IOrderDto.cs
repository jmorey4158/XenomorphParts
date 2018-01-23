using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IOrderDto
    {
        long Id { get; }
        long ReferenceOrderId { get; }
        string Name { get; }
        string Notes { get; }
        long CustomerId { get; }
        decimal Total { get; }
        List<IOrderItemDto> OrderItems { get; }
        string OrderDate { get; }
        long ShipmentId { get; }
    }
}

using System;
using System.Collections.Generic;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Model
{
    public interface IOrder
    {
        long Id { get; }
        IOrder ReferenceOrder { get; }
        string Name { get; }
        string Notes { get; }
        IEntity Customer { get; }
        decimal Total { get; }
        IEnumerable<IOrderItemDto> Items { get; }
        DateTime OrderDate { get; }
        DateTime OrderFulfilled { get; }
        DateTime OrderShipped { get; }
        IEnumerable<IShipment> Shipments { get; }
    }
}

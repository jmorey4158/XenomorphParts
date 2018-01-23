using System;
using System.Collections.Generic;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IOrder
    {
        long OrderId { get; }
        long ReferenceOrder { get; }
        string OrderName { get; }
        string Description { get; }
        ICustomer Customer { get; }
        decimal Total { get; }
        List<IOrderItem> Items { get; }
        DateTime OrderDate { get; }
        DateTime OrderFulfilled { get; }
        DateTime OrderShipped { get; }
        IShipment Shipment { get; }
    }
}

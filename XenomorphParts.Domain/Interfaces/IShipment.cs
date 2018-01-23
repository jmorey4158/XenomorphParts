using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IShipment
    {
        long ShipmentId { get; }
        IOrder Order { get; }
        string ShipmentType { get; }
        string ShipmentMethod { get; }
        ILocation From { get; }
        ILocation To { get; }
        string Status { get; }
        DateTime DateShipped { get; }
        DateTime DateReceived { get; }
    }
}

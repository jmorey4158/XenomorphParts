using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.Model
{
    public interface IShipment
    {
        long Id { get; }
        IOrder Order { get; }
        IEntity Customer { get; }
        IEntity Source { get; }
        string ShipmentType { get; }
        string ShipmentMethod { get; }
        string ShipmentStatus { get; }
        string LocationId { get; }
        DateTime DateShipped { get; }
        DateTime DateReceived { get; }
    }
}

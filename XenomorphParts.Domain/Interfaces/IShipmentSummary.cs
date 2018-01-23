using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IShipmentSummary
    {
        long ShipmentId { get; }
        long OrderId { get; }
        string ShipmentType { get; }
        string DateShipped { get; }
        string DateRecevied { get; }
    }
}

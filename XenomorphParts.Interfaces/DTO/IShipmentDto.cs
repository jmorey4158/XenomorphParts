using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IShipmentDto
    {
        long Id { get;  }
        long OrderId { get; }
        long CustomerId { get; }
        string ShipmentType { get; }
        string ShipmentMethod { get; }
        string ShipmentStatus { get; }
        long LocationId { get; }
        string DateShipped { get; }
        string DateReceived { get; }
    }
}

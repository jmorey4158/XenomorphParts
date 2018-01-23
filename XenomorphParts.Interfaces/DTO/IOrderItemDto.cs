using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IOrderItemDto
    {
        long PartId { get; }
        int Quantity { get; }
        string ShipmentType { get; }
        string ShipmentNotes { get; }
        decimal SubTotal { get; }
    }
}

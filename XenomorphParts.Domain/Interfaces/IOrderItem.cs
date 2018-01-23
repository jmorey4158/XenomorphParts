using XenomorphParts.Domain.Enums;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IOrderItem
    {
        IPart Part { get; }
        int Quantity { get; }
        string ShipmentType { get; }
        string ShipmentNotes { get; }
        decimal SubTotal { get; }
    }
}


namespace XenomorphParts.Interfaces.Model
{
    public interface IOrderItem
    {
        IPart Part { get; }
        int Quantity { get; }
        string ShipmentType { get; }
        string ShipmentNotes { get; }
        decimal SubTotal { get; }
        IShipment Shipment { get; }
    }
}

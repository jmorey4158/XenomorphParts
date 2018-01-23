using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class OrderSummaryDto : IOrderSummaryDto
    {
        private long _orderId;
        public long  OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        private string _orderName;
        public string OrderName
        {
            get { return _orderName; }
            set { _orderName = value; }
        }

        private int _itemsCount;
        public int ItemsCount
        {
            get { return _itemsCount; }
            set { _itemsCount = value; }
        }

        private long _shipmentId;
        public long ShipmentId
        {
            get { return _shipmentId; }
            set { _shipmentId = value; }
        }

        private decimal _total;
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private string _orderDate;
        public string OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
    }
}

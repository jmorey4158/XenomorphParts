using System;
using System.Collections.Generic;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class OrderDto : IOrderDto
    {
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private long _refOrderId;
        public long ReferenceOrderId
        {
            get { return _refOrderId; }
            set { _refOrderId = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        private long _customerId;
        public long CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        private decimal _total;
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private List<IOrderItemDto> _orderItems;
        public List<IOrderItemDto> OrderItems
        {
            get { return _orderItems; }
            set { _orderItems = value; }
        }

        private string _orderDate;
        public string OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        private long _shipmentId;
        public long ShipmentId
        {
            get { return _shipmentId; }
            set { _shipmentId = value; }
        }
    }
}

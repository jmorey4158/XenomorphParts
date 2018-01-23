using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class Order : IOrder
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private IOrder _refOrder;
        public IOrder ReferenceOrder
        {
            get { return _refOrder; }
            set { _refOrder = value; }
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

        private IEntity _customer;
        public IEntity Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private decimal _total;
        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private IEnumerable<IOrderItemDto> _items;
        public IEnumerable<IOrderItemDto> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private DateTime _orderDate;
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        private DateTime _fulfillDate;
        public DateTime OrderFulfilled
        {
            get { return _fulfillDate; }
            set { _fulfillDate = value; }
        }

        private DateTime _shippedDate;
        public DateTime OrderShipped
        {
            get { return _shippedDate; }
            set { _shippedDate = value; }
        }

        private IEnumerable<IShipment> _shipments;
        public IEnumerable<IShipment> Shipments
        {
            get { return _shipments; }
            set { _shipments = value; }
        }


    }
}

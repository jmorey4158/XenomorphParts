using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class Shipment : IShipment
    {

        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private IOrder order;
        public IOrder Order
        {
            get { return order; }
            set { order = value; }
        }

        private IEntity _customer;
        public IEntity Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private IEntity _source;
        public IEntity Source
        {
            get { return _source; }
            set { _source = value; }
        }

        private string _shipType;
        public string ShipmentType
        {
            get { return _shipType; }
            set { _shipType = value; }
        }

        private string _shipMethod;
        public string ShipmentMethod
        {
            get { return _shipMethod; }
            set { _shipMethod = value; }
        }

        private string _shipStatus;
        public string ShipmentStatus
        {
            get { return _shipStatus; }
            set { _shipStatus = value; }
        }

        private string _location;
        public string LocationId
        {
            get { return _location; }
            set { _location = value; }
        }

        private DateTime _shipDate;
        public DateTime DateShipped
        {
            get { return _shipDate; }
            set { _shipDate = value; }
        }

        private DateTime _receivedDate;
        public DateTime DateReceived
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

    }
}

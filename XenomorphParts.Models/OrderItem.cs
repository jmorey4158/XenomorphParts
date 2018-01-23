using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class OrderItem : IOrderItem
    {
        private IPart _part;
        public IPart Part
        {
            get { return _part; }
            set { _part = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private string _shipTYpe;
        public string ShipmentType
        {
            get { return _shipTYpe; }
            set { _shipTYpe = value; }
        }

        private string _shipNotes;
        public string ShipmentNotes
        {
            get { return _shipNotes; }
            set { _shipNotes = value; }
        }

        private decimal _subTotal;
        public decimal SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        private IShipment _ship;
        public IShipment Shipment
        {
            get { return _ship; }
            set { _ship = value; }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class OrderItemDto : IOrderItemDto
    {
        private long _partId;
        public long PartId
        {
            get { return _partId; }
            set { _partId = value; }
        }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private string shipmentType;
        public string ShipmentType
        {
            get { return shipmentType; }
            set { shipmentType = value; }
        }

        private string _shipNotes;
        public string ShipmentNotes
        {
            get { return _shipNotes; }
            set { _shipNotes = value; }
        }

        private decimal _subtotal;
        public decimal SubTotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }

    }
}

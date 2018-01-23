using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class ShipmentDto : IShipmentDto
    {
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private long _orderId;
        public long OrderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }

        private long _customerId;
        public long CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
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


        private long _locationId;
        public long LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        private string _dateShipped;
        public string DateShipped
        {
            get { return _dateShipped; }
            set { _dateShipped = value; }
        }

        private string _dateReceived;
        public string DateReceived
        {
            get { return _dateReceived; }
            set { _dateReceived = value; }
        }
    }
}

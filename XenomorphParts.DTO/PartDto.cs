using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class PartDto : IPartDto
    {
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private decimal _wholesalePrice;
        public decimal WholesalePrice
        {
            get { return _wholesalePrice; }
            set { _wholesalePrice = value; }
        }

        private decimal _retailPrice;
        public decimal RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        private string _manufacturerId;
        public string ManufacturerId
        {
            get { return _manufacturerId; }
            set { _manufacturerId = value; }
        }

        private long _vehicleModelId;
        public long VehicleModelId
        {
            get { return _vehicleModelId; }
            set { _vehicleModelId = value; }
        }

        private int _reserved;
        public int Reserved
        {
            get { return _reserved; }
            set { _reserved = value; }
        }

        private int _available;
        public int Available
        {
            get { return _available; }
            set { _available = value; }
        }

        private int _locatorAvailable;
        public int LocatorAvailable
        {
            get { return _locatorAvailable; }
            set { _locatorAvailable = value; }
        }
    }
}

using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class LocationDto : ILocationDto
    {
        private long _Id;
        public long Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        private string _galaxy;
        public string Galaxy
        {
            get { return _galaxy; }
            set { _galaxy = value; }
        }


        private string _system;
        public string System
        {
            get { return _system; }
            set { _system = value; }
        }

        private string _planet;
        public string Planet
        {
            get { return _planet; }
            set { _planet = value; }
        }

        private string _region;
        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }

        private string _line1;
        public string AddressLine1
        {
            get { return _line1; }
            set { _line1 = value; }
        }

        private string _line2;
        public string AddressLine2
        {
            get { return _line2; }
            set { _line2 = value; }
        }

        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        private string _postal;
        public string PostalCode
        {
            get { return _postal; }
            set { _postal = value; }
        }

        private string _entityType;
        public string EntityType
        {
            get { return _entityType; }
            set { _entityType = value; }
        }

        private string _entityId;
        public string EntityId
        {
            get { return _entityId; }
            set { _entityId = value; }
        }


    }
}

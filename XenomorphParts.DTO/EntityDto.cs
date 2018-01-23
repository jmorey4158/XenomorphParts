using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.DTO
{
    public class EntityDto : IEntityDto
    {
        private string _Id;
        public string Id
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

        private string _locationId;
        public string LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        private string _entity;

        public string EntityType
        {
            get { return _entity; }
            set { _entity = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Model;


namespace XenomorphParts.DTO
{
    public class PartLocatorDto : IPartLocatorDto
    {
        private long _partId;
        public long PartId
        {
            get { return _partId; }
            set { _partId = value; }
        }

        private long _locationId;
        public long LocationId
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        private int _available;
        public int Available
        {
            get { return _available; }
            set { _available = value; }
        }

    }
}

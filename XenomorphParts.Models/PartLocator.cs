using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class PartLocator : IPartLocator
    {
        private long _partId;
        public long PartId
        {
            get { return _partId; }
            set { _partId = value; }
        }

        private ILocation location;
        public ILocation Location
        {
            get { return location; }
            set { location = value; }
        }

        private int _available;
        public int Available
        {
            get { return _available; }
            set { _available = value; }
        }
    }
}

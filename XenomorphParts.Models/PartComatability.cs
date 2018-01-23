using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class PartComatability : IPartCompatability
    {
        private long _partId;
        public long PartId
        {
            get { return _partId; }
            set { _partId = value; }
        }

        private IEnumerable<IVehicleModel> _compatModels;
        public IEnumerable<IVehicleModel> CompatableModels
        {
            get { return _compatModels; }
            set { _compatModels = value; }
        }

        private IEnumerable<IEntity> _compatManufacturers;
        public IEnumerable<IEntity> CompatableManufacturers
        {
            get { return _compatManufacturers; }
            set { _compatManufacturers = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Common.Enums;
using XenomorphParts.Interfaces.Model;

namespace XenomorphParts.Models
{
    public class Entity : IEntity
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        private ILocation location;
        public ILocation Location
        {
            get { return location; }
            set { location = value; }
        }

        private EntityType entityType;
        public EntityType EntityType
        {
            get { return entityType; }
            set { entityType = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using XenomorphParts.Interfaces.Model;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Models
{
    public class Location : ILocation
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
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

        private string _addLine1;
        public string AddressLine1
        {
            get { return _addLine1; }
            set { _addLine1 = value; }
        }

        private string _addLine2;
        public string AddressLine2
        {
            get { return _addLine2; }
            set { _addLine2 = value; }
        }

        private string _entityId;
        public string EntityId
        {
            get { return _entityId; }
            set { _entityId = value; }
        }

        private EntityType _entType;
        public EntityType EntityType
        {
            get { return _entType; }
            set { _entType = value; }
        }


    }
}

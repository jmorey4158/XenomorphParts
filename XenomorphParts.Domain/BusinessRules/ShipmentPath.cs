using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Common.Enums;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Domain.BusinessRules
{
    /// <summary>
    /// The ShipmentPath class defines the Source and Destination along with the Shipping Method between those two points. 
    /// This structure is used by several business rules to determine the best shipping method(s) 
    /// to use between two points, considering time-to-delievery, cost, reliability and other rules.
    /// 
    /// The class represents a list of ShipmentWaypoints that comprise the entire shipment 
    /// journey bewteen the origianl Source and the final destination.
    /// </summary>
    public class ShipmentPath
    {
        private long _shipmentId;
        public long ShipmentId
        {
            get { return _shipmentId; }
            set { _shipmentId = value; }
        }

        private IEnumerable<ShipmentWaypoint> _paths;
        public IEnumerable<ShipmentWaypoint> ShipmentPaths
        {
            get { return _paths; }
            set { _paths = value; }
        }
    }

    /// <summary>
    /// The ShipmentWaypoint class reresents a single waypoint along the shipping journey
    /// bewteen the origianl Source and the final destination. There are one or more of these in the total
    /// journey.
    /// </summary>
    public class ShipmentWaypoint
    {
        private ShipmentMethod _method;
        public ShipmentMethod Method
        {
            get { return _method; }
            set { _method = value; }
        }

        private ILocationDto _source;
        public ILocationDto Source
        {
            get { return _source; }
            set { _source = value; }
        }

        private ILocationDto _destination;
        public ILocationDto Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }
    }
}

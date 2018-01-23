using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Domain.BusinessRules
{
    /// <summary>
    /// The ShippingRules class provides static methods that run shipping-related business rules against 
    /// various DTO objects. This is needed because there might be several possible shipping routes 
    /// between the part source and the final destination and we wnat to fidn the best route.
    /// 
    /// METHOD: MeetsShippingConstraints - runs the proposed route against known shipping constraints
    /// and makes sure that the route complies with those constraints.
    /// 
    /// METHOD: GetShippingConstraints -- retieves shipping rules for a given route.
    /// 
    /// METHOD: FindBestShippingPath -- given a Source and Destination location, finds all the reasonable
    /// shipping routes between them.
    /// 
    /// METHOD: FindBestShippingMethod -- given a Source and Destination location, finds the best
    /// shipping method between them.
    /// </summary>
    public static class ShippingRules
    {
        public static bool MeetsShippingConstraints() { return false; }

        public static void GetShippingConstraints() { }

        public static ShipmentMethod FindBestShippingMethod(ILocationDto source, ILocationDto destination) { return ShipmentMethod.EstrangedParticleBump; }

        public static ShipmentPath FindBestShippingPath(ILocationDto source, ILocationDto destination) { return new ShipmentPath() { }; }
    }
}

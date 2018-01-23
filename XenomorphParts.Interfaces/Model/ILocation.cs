using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Interfaces.Model
{
    public interface ILocation
    {
        string Id { get; }
        string Notes { get; }
        string Galaxy { get; }
        string System { get; }
        string Planet { get; }
        string Region { get; }
        string AddressLine1 { get; }
        string AddressLine2 { get; }
        string State { get; }
        string PostalCode { get; }
        EntityType EntityType { get; }
        string EntityId { get; }
    }
}

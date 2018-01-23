using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface ILocationDto
    {
        long Id { get; }
        string Notes { get; }
        string Galaxy { get; }
        string System { get; }
        string Planet { get; }
        string Region { get; }
        string AddressLine1 { get; }
        string AddressLine2 { get; }
        string State { get; }
        string PostalCode { get; }
        string EntityType { get; }
        string EntityId { get; }
    }
}

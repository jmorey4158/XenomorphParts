using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface ILocation
    {
        long LocationId { get; }
        string Description { get; }
        string Galaxy { get; }
        string Sector { get; }
        string System { get; }
        string Planet { get; }
        string Region { get; }
        string Local { get; }
    }
}

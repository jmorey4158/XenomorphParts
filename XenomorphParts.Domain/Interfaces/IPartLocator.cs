using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IPartLocator
    {
        long PartId { get; }
        long LocationId { get; }
        int Available { get; }
    }
}

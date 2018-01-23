using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.Model
{
    public interface IPartLocator
    {
        long PartId { get; }
        ILocation Location { get; }
        int Available { get; }
    }
}

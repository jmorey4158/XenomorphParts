using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Common.Enums;

namespace XenomorphParts.Interfaces.Model
{
    public interface IEntity
    {
        string Id { get; }
        string Name { get; }
        string Notes { get; }
        ILocation Location { get; }
        EntityType EntityType { get;  }
    }
}

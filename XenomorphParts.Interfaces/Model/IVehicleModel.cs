using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.Model
{
    public interface IVehicleModel
    {
        long Id { get; }
        string Name { get; }
        string Description { get; }
        IEntity Manufacturer { get; }
        int BeginYear { get; }
        int EndYear { get; }
        IAssembly Assembly { get; }
    }
}


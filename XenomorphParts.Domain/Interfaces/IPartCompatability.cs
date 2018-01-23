using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IPartCompatability
    {
        long PartId { get; }
        List<IVehicleModel> CompatableModels { get; }
    }
}

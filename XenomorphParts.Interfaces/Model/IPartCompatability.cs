using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.Model
{
    public interface IPartCompatability
    {
        long PartId { get; }
        IEnumerable<IVehicleModel> CompatableModels { get; }
        IEnumerable<IEntity> CompatableManufacturers { get; }
    }
}

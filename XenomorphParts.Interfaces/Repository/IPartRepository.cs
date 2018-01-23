using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IPartRepository
    {
        IPartDto GetById(long id);
        List<IPartDto> GetByPartName(string name);
        List<IPartDto> GetByPartId(long partId);
        List<IPartDto> GetByVehicleModelId(long modelId);
        List<IPartDto> GetByManufacturerId(long makerId);
    }
}

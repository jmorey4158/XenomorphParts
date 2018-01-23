using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IVehicleModelRepository
    {
        IVehicleModelDto GetById(long id);
        List<IVehicleModelDto> GetByManufacturerId(long maker);
        List<IVehicleModelDto> GetByYear(int year);
        List<IVehicleModelDto> GetByName(string name);
    }
}

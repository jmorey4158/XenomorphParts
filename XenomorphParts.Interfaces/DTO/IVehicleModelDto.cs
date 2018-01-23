using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IVehicleModelDto
    {
        long Id { get; }
        string Name { get; }
        string Description { get; }
        long ManufacturerId { get; }
        int BeginYear { get; }
        int EndYear { get; }
    }
}

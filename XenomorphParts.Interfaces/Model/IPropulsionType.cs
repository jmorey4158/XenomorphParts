using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.Model
{
    public interface IPropulsionType
    {
        int Id { get; }
        string Name { get; }
        string Notes { get; }
        IEntity Manufacturer { get; }
        List<IVehicleModel> Models { get; }
        IAssembly Assembly { get; }
    }
}

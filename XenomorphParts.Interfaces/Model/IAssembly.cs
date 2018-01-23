using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.Model
{
    public interface IAssembly
    {
        long Id { get; }
        IEntity Manufacturer { get; }
        IEnumerable<IPart> Components { get; }
        IEnumerable<IAssembly> SubAssemblies { get; }
    }
}

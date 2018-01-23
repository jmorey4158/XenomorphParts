using System;
using System.Collections.Generic;
using System.Text;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IAssemblyDto
    {
        long Id { get; }
        string Name { get; }
        string Notes { get; }
        string ManufacturerId { get; }
        long ModelId { get; }
        IEnumerable<IPartDto> Components { get; }
        IEnumerable<long> SubAssemblies { get; }
        long Parent { get; }
    }
}

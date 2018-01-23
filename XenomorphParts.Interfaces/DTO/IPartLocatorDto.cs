using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XenomorphParts.Interfaces.DTO
{
    public interface IPartLocatorDto
    {
        long PartId { get; }
        long LocationId { get; }
        int Available { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.Model;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Interfaces.Repository
{
    public interface IPartLocatorRepository
    {
        List<IPartLocatorDto> GetByLocation(long location);
        List<IPartLocatorDto> GetByPart(long part);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IPartRepository
    {
        PartDto GetById(long id);
        List<PartDto> GetByModel(string model);
        List<PartDto> GetByMaker(string maker);
        List<PartDto> GetByPartName(string name);
    }
}

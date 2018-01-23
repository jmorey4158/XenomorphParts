using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;

namespace XenomorphParts.Domain.Interfaces
{
    public interface IPartSummaryRepository
    {
        PartSummaryDto GetById(long id);
        List<PartSummaryDto> GetByModel(string model);
        List<PartSummaryDto> GetByPartName(string name);
        List<PartSummaryDto> GetByMaker(string maker);
    }
}

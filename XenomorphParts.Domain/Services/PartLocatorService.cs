using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Interfaces.DTO;

namespace XenomorphParts.Domain.Services
{
    public class PartLocatorService
    {
        private readonly IPartLocatorRepository _partLocRepo;

        public PartLocatorService(IPartLocatorRepository partLocatorRepository)
        {
            _partLocRepo = partLocatorRepository;
        }

        public List<IPartLocatorDto> GetByPart(long part)
        {
            return _partLocRepo.GetByPart(part);
        }

        public List<IPartLocatorDto> GetByLocation(long locationid)
        {
            return _partLocRepo.GetByLocation(locationid);
        }

    }
}

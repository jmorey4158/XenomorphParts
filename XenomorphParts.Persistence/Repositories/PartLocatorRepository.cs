using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Persistence.Repositories;
using XenomorphParts.Exceptions;
using XenomorphParts.Interfaces.Model;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.DTO;

namespace XenomorphParts.Persistence.Repositories
{
    public class PartLocatorRepository : IPartLocatorRepository
    {
            private static readonly IPartLocatorDto _partLoc1 = new PartLocatorDto()
            {
                PartId = 34598701,
                Available = 171,
                LocationId = 897165
            };

            private static readonly IPartLocatorDto _partLoc2 = new PartLocatorDto()
            {
                PartId = 34598701,
                Available = 171,
                LocationId = 89775
            };

            private static readonly IPartLocatorDto _partLoc3 = new PartLocatorDto()
            {
                PartId = 345901,
                Available = 171,
                LocationId = 145879043
            };

            private List<IPartLocatorDto> _locList = new List<IPartLocatorDto>()
            {
                _partLoc1,
                _partLoc2,
                _partLoc3
            };



        public List<IPartLocatorDto> GetByPart(long part)
        {
            switch (part)
            {
                case 34598701:
                    return new List<IPartLocatorDto>()
                    {
                        _partLoc1, _partLoc2
                    };

                case 345901:
                    return new List<IPartLocatorDto>() { _partLoc3 };

                default:
                    throw new PartLocatorNotFoundException($"Part Locator not fond for Part: {part}.");
            }
        }

        public List<IPartLocatorDto> GetByLocation(long location)
        {
            switch (location)
            {
                case 897165:
                    return new List<IPartLocatorDto>() { _partLoc1 };

                case 89775:
                    return new List<IPartLocatorDto>() { _partLoc2 };

                case 145879043:
                    return new List<IPartLocatorDto>() { _partLoc3 };

                default:
                    throw new PartLocatorNotFoundException($"Part Locator not fond for Location: {location}.");
            }
        }
    }
}

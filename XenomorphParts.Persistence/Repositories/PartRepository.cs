using System;
using System.Collections.Generic;
using XenomorphParts.DTO;
using XenomorphParts.Exceptions;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;

namespace XenomorphParts.Persistence.Repositories
{
    public class PartRepository : IPartRepository
    {
        private readonly IPartDto _partDto1001 = new PartDto()
        {
            Id = 1001,
            Name = "Andorian Plugal Snapring",
            Description = "Fastens the Andorian Plugal Ring to the Sensor Array. Order in sets of 4.",
            ManufacturerId = "8901234",
            VehicleModelId = 1234567,
            WholesalePrice = 1324.89M,
            RetailPrice = 2345.79M,
            Available = 160,
            Reserved = 14,
            LocatorAvailable = 240
        };

        private readonly IPartDto _partDto1313456 = new PartDto()
        {
            Id = 1313456,
            Name = "Andorian Anti-Matter Injector",
            Description = "Injects anti-matter into Warp Core Reactor Chamber. Also compatible with Exzedian Warp Core Chambers. Order in sets of 3.",
            ManufacturerId = "8901234",
            VehicleModelId = 1234567,
            WholesalePrice = 1324.89M,
            RetailPrice = 2345.79M,
            Available = 300,
            Reserved = 33,
            LocatorAvailable = 180
        };


        public IPartDto GetById(long id)
        {
            switch (id)
            {
                case 1001:
                    return _partDto1001;

                case 1313456:
                    return _partDto1313456;

                default:
                    throw new PartNotFoundException($"Part: {id} could not be found.");
            }
        }

        public List<IPartDto> GetByPartName(string name)
        {
            switch (name)
            {
                case "Andorian Anti-Matter Injector":
                    {
                        return new List<IPartDto>()
                        {
                            _partDto1313456
                        };
                    }

                case "Andorian Plugal Snapring":
                    {
                        return new List<IPartDto>()
                        {
                            _partDto1001
                        };
                    }

                default:
                    throw new PartNotFoundException($"Parts for Part Name {name} could not be found.");
            }
        }


        public List<IPartDto> GetByVehicleModelId(long modelId)
        {
            if (modelId == 1234567)
                return new List<IPartDto>() { _partDto1001, _partDto1313456 };
            else
                throw new PartNotFoundException($"Parts for Vehicle Model {modelId} could not be found.");
        }

        public List<IPartDto> GetByManufacturerId(long makerId)
        {
            if (makerId == 8901234)
                return new List<IPartDto>() { _partDto1001, _partDto1313456 };
            else
                throw new PartNotFoundException($"Parts for Manufacturer {makerId} could not be found.");
        }

        public List<IPartDto> GetByPartId(long partId)
        {
            switch (partId)
            {
                case 1001:
                    return new List<IPartDto>() { _partDto1001 };

                case 1313456:
                    return new List<IPartDto>() { _partDto1313456 };
                default:
                    throw new PartNotFoundException($"Part {partId} could not be found.");
            }
        }
    }
}

using System.Collections.Generic;
using XenomorphParts.Exceptions;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.DTO;

namespace XenomorphParts.Persistence.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private static readonly ILocationDto _dto = new LocationDto()
        {
            Id = 234097,
            Notes = "Phlig`garp System, Purentii Prime, Parts Station.",
            Galaxy = "AXL17896",
            System = "Phreem",
            Planet = "Purentii Prime",
            Region = "Caldinor North",
            AddressLine1 = "1278 Buteriqa Drive N",
            AddressLine2 = "SuiteF111",
            State = "Tambari",
            PostalCode = "123456"
        };


        public ILocationDto GetById(string id)
        {
            if (id == "234097")
                return _dto;
            else
                throw new LocationNotFoundException($"Location: {id} could not be found.");
        }


        public List<ILocationDto> GetByGalaxy(string galaxy)
        {
            if (galaxy.Contains("AXL17896"))
            {
                return new List<ILocationDto>()
                {
                    _dto
                };
            }
            else
                throw new LocationNotFoundException($"Location in Galaxy: {galaxy} could not be found.");
        }

        public List<ILocationDto> GetBySystem(string system)
        {
            if (system.Contains("Phreem"))
            {
                return new List<ILocationDto>()
                {
                    _dto
                };
            }
            else
                throw new LocationNotFoundException($"Location in {nameof(LocationDto.System)}: {system} could not be found.");
        }

        public List<ILocationDto> GetByPlanet(string planet)
        {
            if (planet.Contains("Purentii Prime"))
            {
                return new List<ILocationDto>()
                {
                    _dto
                };
            }
            else
                throw new LocationNotFoundException($"Location on {nameof(LocationDto.Planet)}: {planet} could not be found.");
        }

        public List<ILocationDto> GetByRegion(string region)
        {
            if (region.Contains("Caldinor North"))
            {
                return new List<ILocationDto>()
                {
                    _dto
                };
            }
            else
                throw new LocationNotFoundException($"Location in {nameof(LocationDto.Region)}: {region} could not be found.");
        }

        public List<ILocationDto> GetByState(string state)
        {
            if (state.Contains("Tambari"))
            {
                return new List<ILocationDto>()
                {
                    _dto
                };
            }
            else
                throw new LocationNotFoundException($"Location in {nameof(LocationDto.State)}: {state} could not be found.");
        }

        public List<ILocationDto> GetByPostalCode(string postal)
        {
            if (postal.Contains("123456"))
            {
                return new List<ILocationDto>()
                {
                    _dto
                };
            }
            else
                throw new LocationNotFoundException($"Location in {nameof(LocationDto.PostalCode)}: {postal} could not be found.");
        }
    }
}

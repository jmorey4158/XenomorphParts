using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Interfaces.DTO;
using XenomorphParts.Interfaces.Repository;
using XenomorphParts.Exceptions;

namespace XenomorphParts.Domain.Services
{
    public class LocationService : ILocationRepository
    {
        private readonly ILocationRepository _locRepo;

        public LocationService(ILocationRepository locationRepository)
        {
            _locRepo = locationRepository;
        }


        public ILocationDto GetById(string id)
        {
            return _locRepo.GetById(id);
        }


        public List<ILocationDto> GetByGalaxy(string galaxy)
        {
            return _locRepo.GetByGalaxy(galaxy);
        }

        public List<ILocationDto> GetBySystem(string system)
        {
            return _locRepo.GetBySystem(system);
        }

        public List<ILocationDto> GetByPlanet(string planet)
        {
            return _locRepo.GetByPlanet(planet);
        }

        public List<ILocationDto> GetByRegion(string region)
        {
            return _locRepo.GetByRegion(region);
        }

        public List<ILocationDto> GetByState(string state)
        {
            return _locRepo.GetByState(state);
        }

        public List<ILocationDto> GetByPostalCode(string postal)
        {
            return _locRepo.GetByPostalCode(postal);
        }
    }
}

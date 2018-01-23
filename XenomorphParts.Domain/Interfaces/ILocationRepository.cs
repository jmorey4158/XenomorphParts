using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XenomorphParts.Domain.DTO;

namespace XenomorphParts.Domain.Interfaces
{
    public interface ILocationRepository
    {
        LocationDto GetById(long id);
        List<LocationDto> GetByGalaxy(string galaxy);
        List<LocationDto> GetBySector(string sector);
        List<LocationDto> GetBySystem(string system);
        List<LocationDto> GetByPlanet(string planet);
        List<LocationDto> GetByRegion(string region);
        List<LocationDto> GetByLocal(string local);
    }
}
